using Newtonsoft.Json;

namespace ListMonk.SDK.Responses;

public class MediaData
{
  [JsonProperty("data")]
  public Media? Media { get; set; }
}

public class MediaList
{
  [JsonProperty("data")]
  public List<Media>? Media { get; set; }
}

public class Media
{
  [JsonProperty("id")]
  public int Id { get; set; }

  [JsonProperty("uuid")]
  public string? Uuid { get; set; }

  [JsonProperty("filename")]
  public string? Filename { get; set; }

  [JsonProperty("thumb_uri")]
  public string? ThumbUri { get; set; }

  [JsonProperty("uri")]
  public string? Uri { get; set; }

  [JsonProperty("created_at")]
  public DateTime CreatedAt { get; set; }
}
