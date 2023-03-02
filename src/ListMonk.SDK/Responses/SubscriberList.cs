using Newtonsoft.Json;

namespace ListMonk.SDK.Responses;

public class SubscriberListData
{
  [JsonProperty("data")]
  public SubscriberList? Subscribers { get; set; }
}

public class SubscriberList
{
  [JsonProperty("results")]
  public List<Subscriber>? List { get; set; }

  [JsonProperty("query")]
  public string? Query { get; set; }

  [JsonProperty("total")]
  public int Total { get; set; }

  [JsonProperty("per_page")]
  public int PerPage { get; set; }

  [JsonProperty("page")]
  public int Page { get; set; }
}
