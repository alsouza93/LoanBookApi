using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanBook.Persistence;
using LoanBook.Persistence.Api;
using LoanBook.Services;
using LoanBook.Services.Api;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LoanBookApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services
            services.AddSingleton<IBookService, BookService>();
            services.AddSingleton<ILoanService, LoanService>();
            services.AddSingleton<IStudentService, StudentService>();
            //repositories
            services.AddSingleton<IBookRepository, BookRepository>();
            services.AddSingleton<ILoanRepository, LoanRepository>();
            services.AddSingleton<IStudentRepository, StudentRepository>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
