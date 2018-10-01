using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codehaks.Extentions.LiteDb;
using Codehaks.IranData;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ProfileApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddLiteDb(@"Profiles.db");

            services.AddDbContext<IranDbContext>(options =>
                 options.UseSqlite("Data Source=iran.db"));
        }

        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
