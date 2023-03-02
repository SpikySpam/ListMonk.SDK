using ListMonk.SDK.Responses;
using Refit;

namespace ListMonk.SDK;

[Headers("Authorization: Basic")]
public interface ILists
{
  [Get("/api/lists")]
  Task<ListListData> GetAsync();

  [Get("/api/lists/{id}")]
  Task<ListData> GetAsync([Query] int id);

  [Post("/api/lists")]
  Task<ListData> CreateAsync([Body] Requests.List request);

  [Put("/api/lists/{id}")]
  Task<ListData> UpdateAsync([Query] int id, [Body] Requests.List request);

  [Delete("/api/lists/{id}")]
  Task<DeleteResponse> DeleteAsync([Query] int id);
}

public class ListService : ServiceBase
{
  public ILists Api { get; set; }
  public ListService(string url, string username, string password) : base(url, username, password)
  {
    Api = RestService.For<ILists>(url, _refitSettings);
  }
}
