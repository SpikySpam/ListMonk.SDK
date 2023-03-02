using ListMonk.SDK.Responses;
using Refit;

namespace ListMonk.SDK;

[Headers("Authorization: Basic")]
public interface IImports
{
  [Get("/api/import/subscribers")]
  Task<ImportData> GetAsync();

  [Get("/api/import/subscribers/logs")]
  Task<ImportLogData> GetLogsAsync();

  [Post("/api/import/subscribers")]
  Task<ImportData> CreateAsync([Body] Requests.Import request);

  [Delete("/api/import/subscribers")]
  Task<ImportData> DeleteAsync();
}

public class ImportService : ServiceBase
{
  public IImports Api { get; set; }
  public ImportService(string url, string username, string password) : base(url, username, password)
  {
    Api = RestService.For<IImports>(url, _refitSettings);
  }
}
