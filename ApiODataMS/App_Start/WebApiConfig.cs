using ApiODataMS.Models;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiODataMS
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            var enableCorsAttr = new EnableCorsAttribute(origins: "*", headers: "*", methods: "*");
            config.EnableCors(enableCorsAttr);

            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Product>("Products");

            config.MapODataServiceRoute(
                routeName: "odata",
                routePrefix: "v1",
                model: builder.GetEdmModel());

            //config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            json.UseDataContractJsonSerializer = true;
        }
    }
}
