using Mes.Pendant.Samples;
using Xunit;

namespace Mes.Pendant.EntityFrameworkCore.Applications;

[Collection(PendantTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<PendantEntityFrameworkCoreTestModule>
{

}
