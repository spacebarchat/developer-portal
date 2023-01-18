using System.Text.Json.Serialization;

namespace Fosscord.DevPortal.Classes.ResponseTypes;

public class UserInfoResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("discriminator")]
    public string Discriminator { get; set; }

    [JsonPropertyName("avatar")]
    public string Avatar { get; set; }

    [JsonPropertyName("accent_color")]
    public object AccentColor { get; set; }

    [JsonPropertyName("banner")]
    public object Banner { get; set; }

    [JsonPropertyName("phone")]
    public object Phone { get; set; }

    [JsonPropertyName("desktop")]
    public bool Desktop { get; set; }

    [JsonPropertyName("mobile")]
    public bool Mobile { get; set; }

    [JsonPropertyName("premium")]
    public bool Premium { get; set; }

    [JsonPropertyName("premium_type")]
    public int PremiumType { get; set; }

    [JsonPropertyName("bot")]
    public bool Bot { get; set; }

    [JsonPropertyName("bio")]
    public string Bio { get; set; }

    [JsonPropertyName("system")]
    public bool System { get; set; }

    [JsonPropertyName("nsfw_allowed")]
    public bool NsfwAllowed { get; set; }

    [JsonPropertyName("mfa_enabled")]
    public bool MfaEnabled { get; set; }

    [JsonPropertyName("totp_secret")]
    public string TotpSecret { get; set; }

    [JsonPropertyName("totp_last_ticket")]
    public string TotpLastTicket { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("premium_since")]
    public DateTime PremiumSince { get; set; }

    [JsonPropertyName("verified")]
    public bool Verified { get; set; }

    [JsonPropertyName("disabled")]
    public bool Disabled { get; set; }

    [JsonPropertyName("deleted")]
    public bool Deleted { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("flags")]
    public string Flags { get; set; }

    [JsonPropertyName("public_flags")]
    public int PublicFlags { get; set; }

    [JsonPropertyName("purchased_flags")]
    public int PurchasedFlags { get; set; }

    [JsonPropertyName("premium_usage_flags")]
    public int PremiumUsageFlags { get; set; }

    [JsonPropertyName("fingerprints")]
    public List<object> Fingerprints { get; set; }

    [JsonPropertyName("extended_settings")]
    public string ExtendedSettings { get; set; }

    public string AvatarUrl
    {
        get => $"{RuntimeStorage.AppSettings.BaseUrl}/avatars/{Id}/{Avatar}.png";
    }

    public string Token { get; set; }
}