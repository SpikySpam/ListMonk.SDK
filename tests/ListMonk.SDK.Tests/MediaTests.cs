using FluentAssertions;
using ListMonk.SDK;

namespace ListMonk.SDK.Tests;

public class MediaTests : BaseTest
{
    private readonly MediaService _service;

    public MediaTests()
    {
        _service = new MediaService($"http://localhost:{_port}", "listmonk", "listmonk");
    }

    [Fact]
    public async Task GetAll()
    {
        var response = await _service.Api.GetAsync();
        response.Should().NotBeNull();
        response.Media.Should().NotBeNull();
        response.Media!.Count.Should().Be(0);
    }

    //[Fact]
    //public async Task Create()
    //{
    //  var response = await _service.Api.CreateAsync(new MediaRequest()
    //  {
    //    File = @".Config/config.toml"
    //  });
    //  response.Should().NotBeNull();
    //  response.Media.Should().NotBeNull();
    //  response.Media!.Id.Should().Be(3);
    //}

    //[Theory]
    //[InlineData(0)]
    //public async Task DeleteById(int id)
    //{
    //  var response = await _service.Api.DeleteAsync(id);
    //  response.Should().NotBeNull();
    //  response.Deleted.Should().BeTrue();
    //}
}
