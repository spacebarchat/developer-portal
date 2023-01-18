using System.Net.Http.Json;
using Fosscord.DevPortal.Classes.Extensions;
using Fosscord.DevPortal.Classes.ResponseTypes;
using Microsoft.AspNetCore.Components;

namespace Fosscord.DevPortal.Classes.Logic;

public class SessionLogic
{
    public static async Task<bool> IsTokenValid(string token)
    {
        using HttpClient client = HttpClientExtensions.GetNewWithAuth();
        var resp = await client.GetAsync($"{RuntimeStorage.AppSettings.ApiUrl}/users/@me");
        return resp.IsSuccessStatusCode;
    }
    public static async Task<UserInfoResponse> GetUserInfo(string? token = null)
    {
        token ??= RuntimeStorage.AccessToken;
        using HttpClient client = HttpClientExtensions.GetNewWithAuth(token);
        var resp = await client.GetAsync($"{RuntimeStorage.AppSettings.ApiUrl}/users/@me");
        if (resp.IsSuccessStatusCode)
        {
            var user = await resp.Content.ReadFromJsonAsync<UserInfoResponse>();
            user.Token = token;
            return user;
        }
        Console.WriteLine("Failed to get user info");
        Console.WriteLine(await resp.Content.ReadAsStringAsync());
        return null;
    }
}