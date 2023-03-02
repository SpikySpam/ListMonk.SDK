using ListMonk.SDK.Responses;
using Refit;

namespace ListMonk.SDK;

[Headers("Authorization: Basic")]
public interface IMedias
{
  [Get("/api/media")]
  Task<MediaList> GetAsync();

  [Headers("Content-Type: multipart/form-data;")]
  [Post("/api/media")]
  Task<MediaData> CreateAsync([Body] Requests.Media request);

  [Delete("/api/media/{id}")]
  Task<DeleteResponse> DeleteAsync([Query] int id);
}

public class MediaService : ServiceBase
{
  public IMedias Api { get; set; }
  public MediaService(string url, string username, string password) : base(url, username, password)
  {
    Api = RestService.For<IMedias>(url, _refitSettings);
  }
}
