using System.Text.Json.Serialization;
using System.Xml;

namespace Fosscord.DevPortal.Classes.ResponseTypes;

public class ErrorResponse
{
    [JsonPropertyName("code")] public int Code { get; set; }
    [JsonPropertyName("message")] public string Message { get; set; }
    [JsonPropertyName("errors")] public Dictionary<string, ErrorList> Errors { get; set; }

    public override string ToString()
    {
        return $"{Code}: {Message} => {Errors.Values.Sum(x=>x.Errors.Length)} errors:\n" + string.Join("\n", Errors.Select(x=>$"{x.Key}:\n - {string.Join("\n - ", String.Join("---", x.Value.Errors.Select(y=>y.Code + ": " + y.Message)))}"));
    }
}
public class ErrorList
{
    [JsonPropertyName("_errors")] public Error[] Errors { get; set; }
}
public class Error
{
    [JsonPropertyName("message")] public string Message { get; set; }
    [JsonPropertyName("code")] public string Code { get; set; }

    public override string ToString()
    {
        return $"{Code}: {Message}";
    }
}