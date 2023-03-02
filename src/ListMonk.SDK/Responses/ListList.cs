using Newtonsoft.Json;

namespace ListMonk.SDK.Responses;

public class ListListData
{
  [JsonProperty("data")]
  public ListList? Lists { get; set; }
}

public class ListList
{
  [JsonProperty("results")]
  public List<List>? List { get; set; }

  [JsonProperty("query")]
  public string? Query { get; set; }

  [JsonProperty("total")]
  public int Total { get; set; }

  [JsonProperty("per_page")]
  public int PerPage { get; set; }

  [JsonProperty("page")]
  public int Page { get; set; }
}
