using Blazored.LocalStorage;
using Fosscord.DevPortal.Classes.ResponseTypes;

namespace Fosscord.DevPortal.Classes;

public static class RuntimeStorage
{
    public static UserInfoResponse? UserInfo { get; set; }
    public static string AccessToken { get; set; }

    public static List<string> AccessTokens { get; set; } = new();
    public static AppSettings AppSettings { get; set; } = new();
    
    public static Dictionary<string, UserInfoResponse> UsersCache { get; set; } = new();


    //some basic logic
    public static async Task LoadFromLocalStorage(ILocalStorageService localStorage)
    {
        AccessToken = await localStorage.GetItemAsync<string>("fosscord.devportal.token");
        AccessTokens = await localStorage.GetItemAsync<List<string>>("fosscord.devportal.tokens") ?? new();
        UsersCache = await localStorage.GetItemAsync<Dictionary<string, UserInfoResponse>>("fosscord.devportal.user_cache") ?? new();
    }
    public static async Task SaveToLocalStorage(ILocalStorageService localStorage)
    {
        await localStorage.SetItemAsStringAsync("fosscord.devportal.token", AccessToken);
        await localStorage.SetItemAsync("fosscord.devportal.tokens", AccessTokens);
        await localStorage.SetItemAsync("fosscord.devportal.user_cache", UsersCache);
    }
}