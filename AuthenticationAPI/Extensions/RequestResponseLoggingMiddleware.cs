using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationAPI.Extensions
{
    public class RequestResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        public RequestResponseLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            // Read and log request body data
            string requestBodyPayload = await ReadRequestBody(context.Request);
            LogHelper.
        }

        private async Task<string> ReadRequestBody(HttpRequest request)
        {
            HttpRequestRewindExtensions.EnableBuffering(request);

            var body = request.Body;
            var buffer = new byte[Convert.ToInt32(request.ContentLength)];
            await request.Body.ReadAsync(buffer, 0, buffer.Length);
            string requestBody = Encoding.UTF8.GetString(buffer);
            body.Seek(0, System.IO.SeekOrigin.Begin);
            request.Body = body;

            return $"{requestBody}";
        }
    }
}
