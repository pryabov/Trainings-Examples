using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

namespace MVC6Template
{
	public class Startup
	{
		// For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			var a = 7.0f;
			services.AddMvc();
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseMvc();
		}
	}
}
