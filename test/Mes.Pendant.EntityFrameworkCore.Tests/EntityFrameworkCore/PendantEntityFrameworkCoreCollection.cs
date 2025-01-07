using Xunit;

namespace Mes.Pendant.EntityFrameworkCore;

[CollectionDefinition(PendantTestConsts.CollectionDefinitionName)]
public class PendantEntityFrameworkCoreCollection : ICollectionFixture<PendantEntityFrameworkCoreFixture>
{

}
