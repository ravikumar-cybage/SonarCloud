using Microsoft.Extensions.Logging.Abstractions;
using WebApp.Controllers;

namespace Tests;

public class HomeControllerTests
{
    [Fact]
    public void CreateController()
    {
        var sut = new HomeController(new NullLogger<HomeController>());

        Assert.NotNull(sut);
    }
}