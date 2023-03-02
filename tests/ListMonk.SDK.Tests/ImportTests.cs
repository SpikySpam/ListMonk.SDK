using FluentAssertions;
using ListMonk.SDK;

namespace ListMonk.SDK.Tests;

public class ImportTests : BaseTest
{
    private readonly ImportService _service;

    public ImportTests()
    {
        _service = new ImportService($"http://localhost:{_port}", "listmonk", "listmonk");
    }

    [Fact]
    public async Task GetAll()
    {
        var response = await _service.Api.GetAsync();
        response.Should().NotBeNull();
        response.Import.Should().NotBeNull();
        response.Import!.Total.Should().Be(0);
    }

    //[Fact]
    //public async Task Create()
    //{
    //  var response = await _service.Api.CreateAsync(new SDK.Requests.Import()
    //  {
    //    File = ""
    //  });
    //  response.Should().NotBeNull();
    //  response.Import.Should().NotBeNull();
    //  response.Import!.Imported.Should().Be(3);
    //}

    [Fact]
    public async Task DeleteById()
    {
        var response = await _service.Api.DeleteAsync();
        response.Should().NotBeNull();
        response.Import.Should().NotBeNull();
    }
}
