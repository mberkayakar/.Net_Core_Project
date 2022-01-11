using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class Startup
    {
      


        public void ConfigureServices(IServiceCollection services)
        {
            // Burada MVC PATERNİNİ EKLEYECEĞİZ . BU SEBEPLE MODÜLLER BURAYA EKLENECEKTİR. 
            // MVC İLK OLARAK BURAYA EKLENMEKTEDİR. 

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // 2.0 da buraya kadar 
            // yeterlidir. 

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

        // 
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            #region Gelen Tüm İsteklere Hello Word gndermek 
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Berkay AKAR ILK DENEME!");
            //});
            #endregion

            // MiddleWare olarak ekleme yapacağız ;

            // app.UseMvcWithDefaultRoute(); defaultta var olan standart routing i alır controller / action / ? id gibi elle yapılandırmak için aşaüıdaki gibi ekleme yapılması yeterlidir.

            app.UseMvc(routes => {
                routes.MapRoute
                (
                    name: "default",
                    template: "{controller}/{action}/{id?}"
                    );
            });


            // ? koyarak isteğe bağlı bir parametre olarak belirlemiş olduk

        }
    }
}
