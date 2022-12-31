using Fosscord.DevPortal.Classes.ResponseTypes;

namespace Fosscord.DevPortal.Classes;

public static class RuntimeStorage
{
    public static UserInfoResponse? UserInfo { get; set; }
    public static string AccessToken { get; set; }

    public static List<string> AccessTokens { get; set; } = new();
}