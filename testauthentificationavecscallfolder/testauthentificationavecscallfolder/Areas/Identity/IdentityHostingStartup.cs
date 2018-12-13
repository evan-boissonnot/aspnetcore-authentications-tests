using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using testauthentificationavecscallfolder.Models;

[assembly: HostingStartup(typeof(testauthentificationavecscallfolder.Areas.Identity.IdentityHostingStartup))]
namespace testauthentificationavecscallfolder.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        //public IConfiguration Configuration { get; private set; }

        //public IdentityHostingStartup(IConfiguration configuration)
        //{
        //    this.Configuration = configuration
        //}

        public void Configure(IWebHostBuilder builder)
        {
            //builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<testauthentificationavecscallfolderContext>(options =>
            //        options.UseSqlServer(
            //            context.Configuration.GetConnectionString("testauthentificationavecscallfolderContextConnection")));

            //    services.AddDefaultIdentity<IdentityUser>()
            //        .AddEntityFrameworkStores<testauthentificationavecscallfolderContext>();

            //    //services.AddAuthentication()
            //    //    .AddFacebook(options =>
            //    //    {
            //    //        options.AppId = Configuration["Authentication:Facebook:AppId"];
            //    //        options.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
            //    //    });
            //});
        }
    }
}