using Newtonsoft.Json;

namespace ListMonk.SDK.Responses;

public class SubscriberData
{
  [JsonProperty("data")]
  public Subscriber? Subscriber { get; set; }
}

public class Subscriber
{
  [JsonProperty("id")]
  public int Id { get; set; }

  [JsonProperty("uuid")]
  public string? Uuid { get; set; }

  [JsonProperty("email")]
  public string? Email { get; set; }

  [JsonProperty("name")]
  public string? Name { get; set; }

  [JsonProperty("attribs")]
  public ListStatus? Attribs { get; set; }

  [JsonProperty("status")]
  public string? Status { get; set; }

  [JsonProperty("lists")]
  public List<List>? Lists { get; set; }

  [JsonProperty("created_at")]
  public DateTime CreatedAt { get; set; }

  [JsonProperty("updated_at")]
  public DateTime UpdatedAt { get; set; }
}
