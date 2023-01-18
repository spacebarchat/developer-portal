using System.Text.Json.Serialization;

namespace Fosscord.DevPortal.Classes.ResponseTypes;

public class Bot
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("discriminator")]
    public string Discriminator { get; set; }

    [JsonPropertyName("avatar")]
    public object Avatar { get; set; }

    [JsonPropertyName("accent_color")]
    public object AccentColor { get; set; }

    [JsonPropertyName("banner")]
    public object Banner { get; set; }

    [JsonPropertyName("desktop")]
    public bool Desktop { get; set; }

    [JsonPropertyName("mobile")]
    public bool Mobile { get; set; }

    [JsonPropertyName("premium")]
    public bool Premium { get; set; }

    [JsonPropertyName("premium_type")]
    public int PremiumType { get; set; }

    [JsonPropertyName("bot")]
    public bool IsBot { get; set; }

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

    [JsonPropertyName("flags")]
    public string Flags { get; set; }

    [JsonPropertyName("public_flags")]
    public int PublicFlags { get; set; }

    [JsonPropertyName("purchased_flags")]
    public int PurchasedFlags { get; set; }

    [JsonPropertyName("premium_usage_flags")]
    public int PremiumUsageFlags { get; set; }

    [JsonPropertyName("rights")]
    public object Rights { get; set; }

    [JsonPropertyName("fingerprints")]
    public List<object> Fingerprints { get; set; }

    [JsonPropertyName("extended_settings")]
    public string ExtendedSettings { get; set; }
}

public class Owner
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

    [JsonPropertyName("flags")]
    public string Flags { get; set; }

    [JsonPropertyName("public_flags")]
    public int PublicFlags { get; set; }

    [JsonPropertyName("purchased_flags")]
    public int PurchasedFlags { get; set; }

    [JsonPropertyName("premium_usage_flags")]
    public int PremiumUsageFlags { get; set; }

    [JsonPropertyName("rights")]
    public object Rights { get; set; }

    [JsonPropertyName("fingerprints")]
    public List<object> Fingerprints { get; set; }

    [JsonPropertyName("extended_settings")]
    public string ExtendedSettings { get; set; }
}

public class ApplicationResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("icon")]
    public object Icon { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("summary")]
    public string Summary { get; set; }

    [JsonPropertyName("type")]
    public object Type { get; set; }

    [JsonPropertyName("hook")]
    public bool Hook { get; set; }

    [JsonPropertyName("bot_public")]
    public bool BotPublic { get; set; }

    [JsonPropertyName("bot_require_code_grant")]
    public bool BotRequireCodeGrant { get; set; }

    [JsonPropertyName("verify_key")]
    public string VerifyKey { get; set; }

    [JsonPropertyName("flags")]
    public int Flags { get; set; }

    [JsonPropertyName("redirect_uris")]
    public List<object> RedirectUris { get; set; }

    [JsonPropertyName("rpc_application_state")]
    public int RpcApplicationState { get; set; }

    [JsonPropertyName("store_application_state")]
    public int StoreApplicationState { get; set; }

    [JsonPropertyName("verification_state")]
    public int VerificationState { get; set; }

    [JsonPropertyName("interactions_endpoint_url")]
    public object InteractionsEndpointUrl { get; set; }

    [JsonPropertyName("integration_public")]
    public bool IntegrationPublic { get; set; }

    [JsonPropertyName("integration_require_code_grant")]
    public bool IntegrationRequireCodeGrant { get; set; }

    [JsonPropertyName("discoverability_state")]
    public int DiscoverabilityState { get; set; }

    [JsonPropertyName("discovery_eligibility_flags")]
    public int DiscoveryEligibilityFlags { get; set; }

    [JsonPropertyName("tags")]
    public object Tags { get; set; }

    [JsonPropertyName("cover_image")]
    public object CoverImage { get; set; }

    [JsonPropertyName("install_params")]
    public object InstallParams { get; set; }

    [JsonPropertyName("terms_of_service_url")]
    public object TermsOfServiceUrl { get; set; }

    [JsonPropertyName("privacy_policy_url")]
    public object PrivacyPolicyUrl { get; set; }

    [JsonPropertyName("owner")]
    public Owner Owner { get; set; }

    [JsonPropertyName("bot")]
    public Bot Bot { get; set; }
}