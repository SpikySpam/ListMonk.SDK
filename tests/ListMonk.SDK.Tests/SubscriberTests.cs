using FluentAssertions;
using ListMonk.SDK;

namespace ListMonk.SDK.Tests;

public class SubscriberTests : BaseTest
{
    private readonly SubscriberService _service;

    public SubscriberTests()
    {
        _service = new SubscriberService($"http://localhost:{_port}", "listmonk", "listmonk");
    }

    [Fact]
    public async Task GetAll()
    {
        var response = await _service.Api.GetAsync();
        response.Should().NotBeNull();
        response.Subscribers.Should().NotBeNull();
        response.Subscribers!.Total.Should().Be(2);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public async Task GetById(int id)
    {
        var response = await _service.Api.GetAsync(id);
        response.Should().NotBeNull();
        response.Subscriber.Should().NotBeNull();
        response.Subscriber!.Id.Should().Be(id);
    }

    [Fact]
    public async Task Create()
    {
        var response = await _service.Api.CreateAsync(new SDK.Requests.Subscriber()
        {
            Name = "Test",
            Email = "test@test.com"
        });
        response.Should().NotBeNull();
        response.Subscriber.Should().NotBeNull();
        response.Subscriber!.Id.Should().Be(3);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public async Task UpdateById(int id)
    {
        var response = await _service.Api.UpdateAsync(id, new SDK.Requests.Subscriber()
        {
            Name = "Test",
            Email = "test@test.com"
        });
        response.Should().NotBeNull();
        response.Subscriber.Should().NotBeNull();
        response.Subscriber!.Id.Should().Be(id);
        response.Subscriber!.Name.Should().Be("Test");
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
