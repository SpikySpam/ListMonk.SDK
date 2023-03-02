using Newtonsoft.Json;

namespace ListMonk.SDK.Responses;

public class DeleteResponse
{
  [JsonProperty("data")]
  public bool Deleted { get; set; }
}
