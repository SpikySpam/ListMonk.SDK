using Newtonsoft.Json;

namespace ListMonk.SDK.Responses;

public class TemplateData
{
  [JsonProperty("data")]
  public Template? Template { get; set; }
}

public class TemplateList
{
  [JsonProperty("data")]
  public List<Template>? Template { get; set; }
}

public class Template
{
  [JsonProperty("id")]
  public int Id { get; set; }

  [JsonProperty("name")]
  public string? Name { get; set; }

  [JsonProperty("body")]
  public string? Body { get; set; }

  [JsonProperty("type")]
  public string? Type { get; set; }

  [JsonProperty("is_default")]
  public bool IsDefault { get; set; }

  [JsonProperty("created_at")]
  public DateTime CreatedAt { get; set; }

  [JsonProperty("updated_at")]
  public DateTime UpdatedAt { get; set; }
}
