using Newtonsoft.Json;

namespace ListMonk.SDK.Responses;

public class CampaignListData
{
  [JsonProperty("data")]
  public CampaignList? Campaigns { get; set; }
}

public class CampaignList
{
  [JsonProperty("results")]
  public List<Campaign>? Campaign { get; set; }

  [JsonProperty("query")]
  public string? Query { get; set; }

  [JsonProperty("total")]
  public int Total { get; set; }

  [JsonProperty("per_page")]
  public int PerPage { get; set; }

  [JsonProperty("page")]
  public int Page { get; set; }
}
