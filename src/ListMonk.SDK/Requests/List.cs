using Newtonsoft.Json;

namespace ListMonk.SDK.Requests;

public class List
{
  [JsonProperty("name")]
  public string Name { get; set; } = string.Empty;

  [JsonProperty("type")]
  public string Type { get; set; } = "private";

  [JsonProperty("optin")]
  public string OptIn { get; set; } = "single";

  [JsonProperty("tags")]
  public List<string>? Tags { get; set; }
}
