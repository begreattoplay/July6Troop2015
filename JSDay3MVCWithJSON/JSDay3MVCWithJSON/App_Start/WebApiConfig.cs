﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace JSDay3MVCWithJSON
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Remove the XML Formatter
            config.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);

            //Set the Contract Resolver (serialization) to use Camel Casing
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
