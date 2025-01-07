using Mes.Pendant.Samples;
using Xunit;

namespace Mes.Pendant.EntityFrameworkCore.Domains;

[Collection(PendantTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<PendantEntityFrameworkCoreTestModule>
{

}
