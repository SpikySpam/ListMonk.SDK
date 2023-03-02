using Newtonsoft.Json;

namespace ListMonk.SDK.Responses;

public class ListData
{
  [JsonProperty("data")]
  public List? List { get; set; }
}

public class List
{
  [JsonProperty("id")]
  public int Id { get; set; }

  [JsonProperty("subscriber_statuses")]
  public ListStatuses? SubscriptionStatuses { get; set; }

  [JsonProperty("subscription_created_at")]
  public DateTime? SubscriptionCreatedAt { get; set; }

  [JsonProperty("subscription_updated_at")]
  public DateTime? SubscriptionUpdatedAt { get; set; }

  [JsonProperty("uuid")]
  public string? Uuid { get; set; }

  [JsonProperty("name")]
  public string? Name { get; set; }

  [JsonProperty("description")]
  public string? Description { get; set; }

  [JsonProperty("type")]
  public string? Type { get; set; }

  [JsonProperty("optin")]
  public string? OptIn { get; set; }

  [JsonProperty("tags")]
  public List<string>? Tags { get; set; }

  [JsonProperty("subscriber_count")]
  public int SubscriberCount { get; set; }

  [JsonProperty("created_at")]
  public DateTime CreatedAt { get; set; }

  [JsonProperty("updated_at")]
  public DateTime UpdatedAt { get; set; }
}
