using Newtonsoft.Json;

namespace ListMonk.SDK.Requests;

public class Subscriber
{
  [JsonProperty("name")]
  public string Name { get; set; } = string.Empty;

  [JsonProperty("email")]
  public string Email { get; set; } = string.Empty;

  [JsonProperty("status")]
  public string Status { get; set; } = "enabled";

  [JsonProperty("lists")]
  public List<int>? Lists { get; set; }

  [JsonProperty("attribs")]
  public string? Attribs { get; set; }

  [JsonProperty("preconfirm_subscriptions")]
  public bool? PreconfirmSubscriptions { get; set; }
}
