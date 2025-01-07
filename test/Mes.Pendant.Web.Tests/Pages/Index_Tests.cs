using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Mes.Pendant.Pages;

[Collection(PendantTestConsts.CollectionDefinitionName)]
public class Index_Tests : PendantWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
