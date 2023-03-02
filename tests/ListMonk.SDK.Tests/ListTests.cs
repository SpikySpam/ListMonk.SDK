using FluentAssertions;
using ListMonk.SDK;

namespace ListMonk.SDK.Tests;

public class ListTests : BaseTest
{
    private readonly ListService _service;

    public ListTests()
    {
        _service = new ListService($"http://localhost:{_port}", "listmonk", "listmonk");
    }

    [Fact]
    public async Task GetAll()
    {
        var response = await _service.Api.GetAsync();
        response.Should().NotBeNull();
        response.Lists.Should().NotBeNull();
        response.Lists!.Total.Should().Be(2);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public async Task GetById(int id)
    {
        var response = await _service.Api.GetAsync(id);
        response.Should().NotBeNull();
        response.List.Should().NotBeNull();
        response.List!.Id.Should().Be(id);
    }

    [Fact]
    public async Task Create()
    {
        var response = await _service.Api.CreateAsync(new SDK.Requests.List()
        {
            Name = "Test"
        });
        response.Should().NotBeNull();
        response.List.Should().NotBeNull();
        response.List!.Id.Should().Be(3);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public async Task UpdateById(int id)
    {
        var response = await _service.Api.UpdateAsync(id, new SDK.Requests.List()
        {
            Name = "Test"
        });
        response.Should().NotBeNull();
        response.List.Should().NotBeNull();
        response.List!.Id.Should().Be(id);
        response.List!.Name.Should().Be("Test");
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public async Task DeleteById(int id)
    {
        var response = await _service.Api.DeleteAsync(id);
        response.Should().NotBeNull();
        response.Deleted.Should().BeTrue();
    }
}
