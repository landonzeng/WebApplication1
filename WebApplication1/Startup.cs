using Furion;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Serilog;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Net;
using System.Reflection;

namespace AIOT.Web.Core
{
    /// <summary>
    /// 
    /// </summary>
    [AppStartup(9)]
    public class Startup : AppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddConfigurableOptions<DbConnectionOptions>();

            services.AddResponseCompression();

            services.AddCorsAccessor();

            services.AddSpecificationDocuments();

            services.AddControllers();
            // 日志监听
            services.AddMonitorLogging();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseStaticFiles();
            
            app.UseSerilogRequestLogging();

            app.UseCorsAccessor();

            app.UseSpecificationDocuments();

           
            app.UseInject("swagger");

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
