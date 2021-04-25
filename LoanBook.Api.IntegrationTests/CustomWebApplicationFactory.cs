using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanBook.Api.IntegrationTests
{
    public class CustomWebApplicationFactory<TStartup>
        :WebApplicationFactory<TStartup> where TStartup : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.UseStartup<TStartup>();
            builder.UseSetting("Environment", "TEST");
            base.ConfigureWebHost(builder);
        }
    }
}
