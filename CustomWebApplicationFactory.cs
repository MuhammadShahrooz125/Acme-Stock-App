using AcmeStockBAL.Services;
using AcmeStockDAL.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;

namespace IntegrationTest;

public class CustomWebApplicationFactory : WebApplicationFactory<Program>
{
    private const string TestConnectionString ="Server=SHERSERVE-1048;Database=AcmeStockTestDb;Trusted_Connection=True;TrustServerCertificate=True";
     
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.UseEnvironment("Testing");

        builder.ConfigureServices(services =>
        {
           
            services.RemoveAll(typeof(DbContextOptions<AppDbContext>));
            services.RemoveAll(typeof(IDbContextOptionsConfiguration<AppDbContext>));

           
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(TestConnectionString));


            services.RemoveAll<IRecaptchaService>();
            services.AddScoped<IRecaptchaService, FakeRecaptchaService>();

            services.RemoveAll<IEmailService>();
            services.AddSingleton<FakeEmailService>();
            services.AddSingleton<IEmailService>(x => x.GetRequiredService<FakeEmailService>());
        });
    }





    protected override IHost CreateHost(IHostBuilder builder)
    {
        var host = base.CreateHost(builder);

        using var scope = host.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        db.Database.EnsureDeleted();
        db.Database.Migrate();
        

        return host;
    }




}