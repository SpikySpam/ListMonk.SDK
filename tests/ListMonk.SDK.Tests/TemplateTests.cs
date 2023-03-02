using FluentAssertions;
using ListMonk.SDK;

namespace ListMonk.SDK.Tests;

public class TemplateTests : BaseTest
{
    private readonly TemplateService _service;

    public TemplateTests()
    {
        _service = new TemplateService($"http://localhost:{_port}", "listmonk", "listmonk");
    }

    [Fact]
    public async Task GetAll()
    {
        var response = await _service.Api.GetAsync();
        response.Should().NotBeNull();
        response.Template.Should().NotBeNull();
        response.Template!.Count.Should().Be(2);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public async Task GetById(int id)
    {
        var response = await _service.Api.GetAsync(id);
        response.Should().NotBeNull();
        response.Template.Should().NotBeNull();
        response.Template!.Id.Should().Be(id);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public async Task GetPreviewById(int id)
    {
        var response = await _service.Api.GetPreviewAsync(id);
        response.Should().NotBeNullOrEmpty();
    }

    //[Fact]
    //public async Task Create()
    //{
    //  var response = await _service.Api.CreateAsync(new SDK.Responses.Template()
    //  {
    //    Name = "Test Template",
    //    Body = "",
    //    Type = "campaign",
    //    IsDefault = false,
    //  });
    //  response.Should().NotBeNull();
    //  response.Template.Should().NotBeNull();
    //  response.Template!.Id.Should().Be(3);
    //}

    //[Fact]
    //public async Task UpdateById()
    //{
    //  var response = await _service.Api.UpdateAsync(1, new SDK.Responses.Template()
    //  {
    //    Name = "Test Template",
    //    Body = "",
    //    Type = "campaign",
    //    IsDefault = false,
    //  });
    //  response.Should().NotBeNull();
    //  response.Template.Should().NotBeNull();
    //  response.Template!.Id.Should().Be(3);
    //}

    [Theory]
    [InlineData(1)]
    //[InlineData(2)]
    public async Task SetDefaultById(int id)
    {
        var response = await _service.Api.SetDefaultAsync(id);
        response.Should().NotBeNull();
        response.Template.Should().NotBeNull();
        response.Template!.IsDefault.Should().BeTrue();
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public async Task DeleteById(int id)
    {
        var response = await _service.Api.GetAsync(id);
        response.Should().NotBeNull();
        response.Template.Should().NotBeNull();
        response.Template!.Id.Should().Be(id);
        if (!response.Template!.IsDefault)
        {
            var delete = await _service.Api.DeleteAsync(id);
            delete.Should().NotBeNull();
            delete.Deleted.Should().BeTrue();
        }
    }
}
