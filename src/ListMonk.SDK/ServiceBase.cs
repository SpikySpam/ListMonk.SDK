using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;
using System.Text;

namespace ListMonk.SDK;

public class ServiceBase
{
  protected RefitSettings? _refitSettings;
  public ServiceBase(string url, string username, string password)
  {
    _refitSettings = new RefitSettings
    {
      ContentSerializer = new NewtonsoftJsonContentSerializer(
        new JsonSerializerSettings
        {
          ContractResolver = new CamelCasePropertyNamesContractResolver()
        }),
      AuthorizationHeaderValueGetter = () => Task.FromResult(Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}")))
    };
  }
}
