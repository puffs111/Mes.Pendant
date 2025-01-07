using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Mes.Pendant.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class PendantDbContextFactory : IDesignTimeDbContextFactory<PendantDbContext>
{
    public PendantDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        PendantEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<PendantDbContext>()
            .UseMySql(configuration.GetConnectionString("Default"), MySqlServerVersion.LatestSupportedServerVersion);
        
        return new PendantDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Mes.Pendant.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
