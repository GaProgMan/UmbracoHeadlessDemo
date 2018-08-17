
using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using Umbraco.Headless.Client.Configuration;
using Umbraco.Headless.Client.Services;

namespace UmbracoHeadlessFunction
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequest req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            Guid.TryParse( req.Query["id"], out Guid id);

            var service = new HeadlessService(new HeadlessConfiguration("https://davids-placid-giraffe.s1.umbraco.io",
                "api@davidbrendel.de", "&>u08E_i:r"));

            var content = service.GetById(id).Result;

            return content != null
                ? (ActionResult)new OkObjectResult($"Hello, {content.Name}")
                : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }
}