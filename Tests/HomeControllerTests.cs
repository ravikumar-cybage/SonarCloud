using Xunit;
using Microsoft.Extensions.Logging.Abstractions;
using WebApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace Tests;

public class HomeControllerTests
{
    private readonly HomeController _controller;

    public HomeControllerTests()
    {
        _controller = new HomeController(new NullLogger<HomeController>());
    }

    [Fact]
    public void Index_ReturnsViewResult()
    {
        // Act
        var result = _controller.Index() as ViewResult;
        
        // Assert
        Assert.NotNull(result);
    }

    [Fact]
    public void Privacy_ReturnsViewResult()
    {
        var result = _controller.Privacy() as ViewResult;
        Assert.NotNull(result);
    }

    [Fact]
    public void Error_ReturnsViewWithErrorModel()
    {
        var result = _controller.Error() as ViewResult;
        Assert.NotNull(result);
        Assert.IsType<ErrorViewModel>(result.Model);
    }
}
