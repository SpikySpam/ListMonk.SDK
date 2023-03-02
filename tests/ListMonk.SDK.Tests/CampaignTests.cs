using FluentAssertions;
using ListMonk.SDK;

namespace ListMonk.SDK.Tests;

public class CampaignTests : BaseTest
{
    private readonly CampaignService _service;

    public CampaignTests()
    {
        _service = new CampaignService($"http://localhost:{_port}", "listmonk", "listmonk");
    }

    [Fact]
    public async Task GetAll()
    {
        var response = await _service.Api.GetAsync();
        response.Should().NotBeNull();
        response.Campaigns.Should().NotBeNull();
        response.Campaigns!.Total.Should().Be(1);
    }

    [Theory]
    [InlineData(1)]
    public async Task GetById(int id)
    {
        var response = await _service.Api.GetAsync(id);
        response.Should().NotBeNull();
        response.Campaign.Should().NotBeNull();
        response.Campaign!.Id.Should().Be(id);
    }

    [Theory]
    [InlineData(1)]
    public async Task GetPreviewById(int id)
    {
        var response = await _service.Api.GetPreviewAsync(id);
        response.Should().NotBeNullOrEmpty();
    }

    [Theory]
    [InlineData(1)]
    public async Task GetStatsById(int id)
    {
        var response = await _service.Api.GetStatsAsync(id);
        response.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task Create()
    {
        var response = await _service.Api.CreateAsync(new SDK.Requests.Campaign()
        {
            Name = "Test",
            Subject = "Test Campaign",
            Body = "Test Campaign",
            Lists = new List<int>() { 1 }
        });
        response.Should().NotBeNull();
        response.Campaign.Should().NotBeNull();
        response.Campaign!.Id.Should().Be(2);
    }

    //[Theory]
    //[InlineData(1)]
    //public async Task TestById(int id)
    //{
    //  var response = await _service.Api.TestAsync(id);
    //  response.Should().NotBeNull();
    //}

    [Theory]
    [InlineData(1)]
    public async Task UpdateById(int id)
    {
        var response = await _service.Api.UpdateAsync(id, new SDK.Requests.Campaign()
        {
            Name = "Test",
            Subject = "Test Campaign",
            Body = "Test Campaign",
            Lists = new List<int>() { 1 }
        });
        response.Should().NotBeNull();
        response.Campaign.Should().NotBeNull();
        response.Campaign!.Id.Should().Be(id);
        response.Campaign!.Name.Should().Be("Test");
    }

    //[Theory]
    //[InlineData(1)]
    //public async Task UpdateStatus(int id)
    //{
    //  var response = await _service.Api.UpdateAsync(id, "{\"status\":\"scheduled\"}");
    //  response.Should().NotBeNull();
    //}

    [Theory]
    [InlineData(1)]
    public async Task DeleteById(int id)
    {
        var response = await _service.Api.DeleteAsync(id);
        response.Should().NotBeNull();
        response.Deleted.Should().BeTrue();
    }
}
