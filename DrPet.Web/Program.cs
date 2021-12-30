using DrPet.Data.Seed.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DrPet.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // this section has been rewritten
            // when we start the project, the database is always updated to the latest migration status
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<Data.DrPetDbContext>();
                var migrations = dbContext.Database.GetMigrations().ToHashSet();
                if (dbContext.Database.GetAppliedMigrations().Any(a => !migrations.Contains(a)))
                    throw new InvalidOperationException("Az adatb�zison m�r van olyan migr�ci� futtatva, amit az�ta t�r�ltek a projektb�l. T�r�ld az adatb�zist vagy jav�tsd a migr�ci�k �llapot�t, majd ind�tsd �jra az alkalmaz�st!");
                dbContext.Database.Migrate();

                // create the admin role
                var roleSeeder = scope.ServiceProvider.GetRequiredService<IRoleSeedService>();
                await roleSeeder.SeedRoleAsync();

                // create the admin user
                var userSeeder = scope.ServiceProvider.GetRequiredService<IUserSeedService>();
                await userSeeder.SeedUserAsync();

                var appUserWorkerSeeder = scope.ServiceProvider.GetRequiredService<IAppUserWorkerSeedService>();
                await appUserWorkerSeeder.SeedAppUserWorkerAsync();
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureKestrel(options =>
                    {
                        options.Limits.MaxRequestBodySize = 50 * 1024 * 1024;
                    });
                    webBuilder.UseStartup<Startup>();
                });
    }
}
