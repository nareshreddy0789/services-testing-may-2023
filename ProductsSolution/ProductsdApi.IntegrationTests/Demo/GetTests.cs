using Alba;
namespace ProductsApi.IntegrationTests.Demo;



public class GetTests
{
    [Fact]
    public async Task GivesA200StatusCode()
    {



        await using var host = await AlbaHost.For<Program>();



        // "Scenarios"
        await host.Scenario(api =>
        {
            api.Get.Url("/demo");
            api.StatusCodeShouldBeOk();
        });



    }
}