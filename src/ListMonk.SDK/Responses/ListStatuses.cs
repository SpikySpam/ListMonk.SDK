using Newtonsoft.Json;

namespace ListMonk.SDK.Responses;

public class ListStatuses
{
  [JsonProperty("unconfirmed")]
  public int Unconfirmed { get; set; }
}
