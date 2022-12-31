using System.Net.Http.Headers;

namespace Fosscord.DevPortal.Classes.Extensions;

public class HttpClientExtensions
{
    public static HttpClient GetNewWithAuth()
    {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", RuntimeStorage.AccessToken);
        return client;
    }
}