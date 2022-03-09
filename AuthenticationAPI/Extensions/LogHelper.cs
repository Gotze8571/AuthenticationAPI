using Generic.Core.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationAPI.Extensions
{
    public static class LogHelper
    {
        private static string RequestPayload = "";

        public static async void EnrichFromRequest(IDiagnosticContext diagnosticContext, HttpContext httpContext)
        {
            var request = httpContext.Request;

            diagnosticContext.Set("RequestBody", RequestPayload);

            string responseBodyPayload = await ReadResponseBody(httpContext.Response);
            diagnosticContext.Set("ResponseBody", responseBodyPayload);
            ApiResponse responseBody = (ApiResponse)JsonConvert.DeserializeObject(responseBodyPayload, typeof(ApiResponse));

            if (responseBody != null)
            {
                diagnosticContext.Set("ResponseCode", responseBody.Code);
                diagnosticContext.Set("Description", responseBody.Description);
            }

            // Set all the common properties available for every request
            diagnosticContext.Set("Host", request.Host);
            diagnosticContext.Set("Protocol", request.Protocol);
            diagnosticContext.Set("Scheme", request.Scheme);

        }

        private static Task<string> ReadResponseBody(HttpResponse response)
        {
            throw new NotImplementedException();
        }
    }
}
