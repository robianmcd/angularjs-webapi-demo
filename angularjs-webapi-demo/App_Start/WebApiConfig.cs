using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace angularjs_webapi_demo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Taken from: social.msdn.microsoft.com/Forums/vstudio/en-US/a5adf07b-e622-4a12-872d-40c753417645/
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
