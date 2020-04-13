using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ModulaIot.Controller.DataBase;

namespace ModulaIot.Controller.DataBase
{
    public class ModulaIotContext : DbContext
    {

        public DbSet<Device> Devices { get; set; }

        public ModulaIotContext(DbContextOptions options) : base(options)
        {

        }

        public void Initialize()
        {
            var created = Database.EnsureCreated();

            if (!created) return;
        }
    }
}

namespace Microsoft.Extensions.Hosting
{
    public static class HostExtensions
    {
        public static IHost CreateDbIfNotExists(this IHost host)
        {
            using var services = host.Services.CreateScope();
            var context = services.ServiceProvider.GetRequiredService<ModulaIotContext>();
            context.Initialize();

            return host;
        }
    }
}