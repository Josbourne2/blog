using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;

namespace MessageDecoderAPI.Middleware
{

    public class CorrelationIdHeaderParameterFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            
            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "CorrelationId",
                In = ParameterLocation.Header,
                Description = "Value to correlate chain of event data in logs",
                Required = false,
                Schema = new OpenApiSchema
                {
                    Type = "string"                    
                }
            });
            
        }
    }
}
