using System.Net;
using ConfigFunctionDemo.Configuration;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace ConfigFunctionDemo
{
    public class Function1
    {
        private readonly ILogger _logger;
        private readonly ParentOptions _settings;

        public Function1(ILoggerFactory loggerFactory, ParentOptions settings)
        {
            _logger = loggerFactory.CreateLogger<Function1>();
            _settings = settings;
        }

        [Function("Function1")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);

            //Let's see if we have our config right...
            response.WriteAsJsonAsync(_settings);

            return response;
        }
    }
}
