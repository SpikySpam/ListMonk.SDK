using ListMonk.SDK.Responses;
using Refit;

namespace ListMonk.SDK;

[Headers("Authorization: Basic")]
public interface ISubscribers
{
  [Get("/api/subscribers")]
  Task<SubscriberListData> GetAsync();

  [Get("/api/subscribers/{id}")]
  Task<SubscriberData> GetAsync([Query] int id);

  [Get("/api/subscribers/lists/{id}")]
  Task<string> GetPreviewAsync([Query] int id);

  [Post("/api/subscribers")]
  Task<SubscriberData> CreateAsync([Body] Requests.Subscriber request);

  [Put("/api/subscribers/{id}")]
  Task<SubscriberData> UpdateAsync([Query] int id, [Body] Requests.Subscriber request);

  [Delete("/api/subscribers/{id}")]
  Task<DeleteResponse> DeleteAsync([Query] int id);
}

public class SubscriberService : ServiceBase
{
  public ISubscribers Api { get; set; }
  public SubscriberService(string url, string username, string password) : base(url, username, password)
  {
    Api = RestService.For<ISubscribers>(url, _refitSettings);
  }
}
