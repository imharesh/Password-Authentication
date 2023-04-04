using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AUTH.Pages;

public class Index_Tests : AUTHWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
