using Newtonsoft.Json;

namespace ListMonk.SDK.Responses;

public class ImportData
{
  [JsonProperty("data")]
  public Import? Import { get; set; }
}

public class ImportLogData
{
  [JsonProperty("data")]
  public string? Import { get; set; }
}

public class Import
{
  [JsonProperty("name")]
  public string? Name { get; set; }

  [JsonProperty("total")]
  public int Total { get; set; }

  [JsonProperty("imported")]
  public int Imported { get; set; }

  [JsonProperty("status")]
  public string? Status { get; set; }
}
