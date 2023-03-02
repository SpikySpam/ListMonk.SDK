using Newtonsoft.Json;

namespace ListMonk.SDK.Responses;

public class CampaignData
{
  [JsonProperty("data")]
  public Campaign? Campaign { get; set; }
}

public class Campaign
{
  [JsonProperty("id")]
  public int Id { get; set; }

  [JsonProperty("uuid")]
  public string? Uuid { get; set; }

  [JsonProperty("template_id")]
  public int TemplateId { get; set; }

  [JsonProperty("name")]
  public string? Name { get; set; }

  [JsonProperty("subject")]
  public string? Subject { get; set; }

  [JsonProperty("from_email")]
  public string? FromMail { get; set; }

  [JsonProperty("body")]
  public string? Body { get; set; }

  [JsonProperty("altbody")]
  public string? AltBody { get; set; }

  [JsonProperty("content_type")]
  public string? ContentType { get; set; }

  [JsonProperty("messenger")]
  public string? Messenger { get; set; }

  [JsonProperty("type")]
  public string? Type { get; set; }

  [JsonProperty("status")]
  public string? Status { get; set; }

  [JsonProperty("to_send")]
  public int ToSend { get; set; }

  [JsonProperty("sent")]
  public int Sent { get; set; }

  [JsonProperty("views")]
  public int Views { get; set; }

  [JsonProperty("clicks")]
  public int Clicks { get; set; }

  [JsonProperty("bounces")]
  public int Bounces { get; set; }

  [JsonProperty("lists")]
  public List<List>? Lists { get; set; }

  [JsonProperty("tags")]
  public List<string>? Tags { get; set; }

  [JsonProperty("headers")]
  public List<string>? Headers { get; set; }

  [JsonProperty("started_at")]
  public DateTime? StartedAt { get; set; }

  [JsonProperty("send_at")]
  public DateTime? SendAt { get; set; }

  [JsonProperty("created_at")]
  public DateTime CreatedAt { get; set; }

  [JsonProperty("updated_at")]
  public DateTime UpdatedAt { get; set; }

  [JsonProperty("archive")]
  public bool? Archive { get; set; }

  [JsonProperty("archive_template_id")]
  public int ArchiveTemplateId { get; set; }
}
