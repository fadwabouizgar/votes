using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace VotesAPI
{	/*allows us to include the values of configuration */
    public class Startup
    {
		/*allows us to append services to the container of dependency injection*/
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
		/*allows us to append middleware and services to the HTTP pipeline*/ 
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}

