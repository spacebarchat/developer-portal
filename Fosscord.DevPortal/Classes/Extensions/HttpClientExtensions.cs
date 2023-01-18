using System.Net.Http.Headers;

namespace Fosscord.DevPortal.Classes.Extensions;

public class HttpClientExtensions
{
    public static HttpClient GetNewWithAuth(string? token = null)
    {
        token ??= RuntimeStorage.AccessToken;
        var client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        return client;
    }
}