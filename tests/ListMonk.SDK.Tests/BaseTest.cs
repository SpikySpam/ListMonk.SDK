using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;
using DotNet.Testcontainers.Networks;

namespace ListMonk.SDK.Tests;

public class BaseTest
{
  protected readonly int _port;

  protected readonly INetwork _listMonkNetwork;

  protected readonly IContainer _postgreSqlContainer;

  protected readonly IContainer _listMonkContainer;

  public BaseTest()
  {
    _listMonkNetwork =
      new NetworkBuilder()
      .WithName(Guid.NewGuid().ToString("D"))
      .Build();
    _listMonkNetwork.CreateAsync().Wait();

    _postgreSqlContainer =
       new ContainerBuilder()
       .WithHostname("postgres")
       .WithImage("postgres:latest")
       .WithName(Guid.NewGuid().ToString("D"))
       .WithEnvironment("POSTGRES_USER", "listmonk")
       .WithEnvironment("POSTGRES_PASSWORD", "listmonk")
       .WithEnvironment("POSTGRES_DB", "listmonk")
       .WithNetwork(_listMonkNetwork)
       .WithWaitStrategy(Wait.ForUnixContainer().UntilPortIsAvailable(5432))
       .Build();
    _postgreSqlContainer.StartAsync().Wait();

    _listMonkContainer =
     new ContainerBuilder()
     .WithImage("listmonk/listmonk:latest")
     .WithName(Guid.NewGuid().ToString("D"))
     .WithPortBinding(9000, true)
     .WithEnvironment("TZ", "Etc/UTC")
     .WithResourceMapping("./Config/config.toml", "/listmonk/config.toml")
     .WithEntrypoint("sh", "-c")
     .WithCommand("yes | ./listmonk --install --config config.toml && ./listmonk --config config.toml")
     .WithWaitStrategy(Wait.ForUnixContainer().UntilPortIsAvailable(9000))
     .WithNetwork(_listMonkNetwork)
     .Build();
    _listMonkContainer.StartAsync().Wait();

    _port = _listMonkContainer.GetMappedPublicPort(9000);
  }
}
