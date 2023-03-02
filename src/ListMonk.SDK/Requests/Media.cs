using Newtonsoft.Json;

namespace ListMonk.SDK.Requests;

public class Media
{
  [JsonProperty("file")]
  public string? File { get; set; }
}
