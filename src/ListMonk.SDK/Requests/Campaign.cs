using Newtonsoft.Json;

namespace ListMonk.SDK.Requests;

public class Campaign
{
  [JsonProperty("template_id")]
  public int? TemplateId { get; set; }

  [JsonProperty("name")]
  public string Name { get; set; } = string.Empty;

  [JsonProperty("subject")]
  public string Subject { get; set; } = string.Empty;

  [JsonProperty("from_email")]
  public string? FromMail { get; set; }

  [JsonProperty("body")]
  public string Body { get; set; } = string.Empty;

  [JsonProperty("altbody")]
  public string? AltBody { get; set; }

  [JsonProperty("content_type")]
  public string ContentType { get; set; } = "plain";

  [JsonProperty("messenger")]
  public string? Messenger { get; set; }

  [JsonProperty("type")]
  public string Type { get; set; } = "regular";

  [JsonProperty("lists")]
  public List<int> Lists { get; set; } = new();

  [JsonProperty("tags")]
  public List<string>? Tags { get; set; }

  [JsonProperty("send_at")]
  public DateTime? SendAt { get; set; }
}
