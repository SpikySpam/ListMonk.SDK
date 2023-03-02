using Newtonsoft.Json;

namespace ListMonk.SDK.Requests;

public class Import
{
  [JsonProperty("params")]
  public string Params { get; set; } = string.Empty;

  [JsonProperty("file")]
  public string File { get; set; } = string.Empty;
}
