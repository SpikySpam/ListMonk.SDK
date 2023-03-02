using ListMonk.SDK.Responses;
using Refit;

namespace ListMonk.SDK;

[Headers("Authorization: Basic")]
public interface ITemplates
{
  [Get("/api/templates")]
  Task<TemplateList> GetAsync();

  [Get("/api/templates/{id}")]
  Task<TemplateData> GetAsync([Query] int id);

  [Get("/api/templates/{id}/preview")]
  Task<string> GetPreviewAsync([Query] int id);

  [Post("/api/templates/preview")]
  Task<TemplateData> CreateAsync([Body] string body);

  [Post("/api/templates")]
  Task<TemplateData> CreateAsync([Body] Template request);

  [Put("/api/templates/{id}")]
  Task<TemplateData> UpdateAsync([Query] int id, [Body] Template request);

  [Put("/api/templates/{id}/default")]
  Task<TemplateData> SetDefaultAsync([Query] int id);

  [Delete("/api/templates/{id}")]
  Task<DeleteResponse> DeleteAsync([Query] int id);
}

public class TemplateService : ServiceBase
{
  public ITemplates Api { get; set; }
  public TemplateService(string url, string username, string password) : base(url, username, password)
  {
    Api = RestService.For<ITemplates>(url, _refitSettings);
  }
}
