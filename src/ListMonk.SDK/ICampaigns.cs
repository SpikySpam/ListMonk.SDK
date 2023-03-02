using ListMonk.SDK.Responses;
using Refit;

namespace ListMonk.SDK;

[Headers("Authorization: Basic")]
public interface ICampaigns
{
  [Get("/api/campaigns")]
  Task<CampaignListData> GetAsync();

  [Get("/api/campaigns/{id}")]
  Task<CampaignData> GetAsync([Query] int id);

  [Get("/api/campaigns/{id}/preview")]
  Task<string> GetPreviewAsync([Query] int id);

  [Get("/api/campaigns/running/stats?campaign_id={id}")]
  Task<string> GetStatsAsync([Query] int id);

  [Post("/api/campaigns")]
  Task<CampaignData> CreateAsync([Body] Requests.Campaign request);

  [Post("/api/campaigns/{id}/test")]
  Task<string> TestAsync([Query] int id);

  [Put("/api/campaigns/{id}")]
  Task<CampaignData> UpdateAsync([Query] int id, [Body] Requests.Campaign request);

  [Headers("Content-Type: application/json")]
  [Put("/api/campaigns/{id}/status")]
  Task<string> UpdateAsync([Query] int id, [Body] string status);

  [Delete("/api/campaigns/{id}")]
  Task<DeleteResponse> DeleteAsync([Query] int id);
}

public class CampaignService : ServiceBase
{
  public ICampaigns Api { get; set; }
  public CampaignService(string url, string username, string password) : base(url, username, password)
  {
    Api = RestService.For<ICampaigns>(url, _refitSettings);
  }
}
