using Newtonsoft.Json;

namespace ListMonk.SDK.Responses;

public class ListStatus
{
  [JsonProperty("city")]
  public string? City { get; set; }

  [JsonProperty("good")]
  public bool Good { get; set; }

  [JsonProperty("type")]
  public string? Type { get; set; }
}
