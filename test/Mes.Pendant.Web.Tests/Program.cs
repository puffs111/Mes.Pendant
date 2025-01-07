using Microsoft.AspNetCore.Builder;
using Mes.Pendant;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("Mes.Pendant.Web.csproj"); 
await builder.RunAbpModuleAsync<PendantWebTestModule>(applicationName: "Mes.Pendant.Web");

public partial class Program
{
}
