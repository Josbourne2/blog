using Microsoft.OpenApi.Models;
using NswagApiDemo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    //This is for exposing an optional header parameter, in this case a correlation id
    //c.OperationFilter<CorrelationIdHeaderParameterFilter>();

    //From Swashbuckle.AspNetCore.Filters. This displays the authentication scheme registered by AddAuthentication...
    var securityDefinition = new OpenApiSecurityScheme
    {
        Reference = new OpenApiReference
        {
            Type = ReferenceType.SecurityScheme,
            Id = "ApiKey"
        },
        Description = "Api key",
        In = ParameterLocation.Header,
        Name = "ApiKey",
        Type = SecuritySchemeType.ApiKey
    };

    c.AddSecurityDefinition("ApiKey", securityDefinition);

    // Security Requirement
    c.AddSecurityRequirement(new OpenApiSecurityRequirement() {
                { securityDefinition, Array.Empty<string>() }
            });
});

//From Swashbuckle.AspNetCore.Newtonsoft
builder.Services.AddSwaggerGenNewtonsoftSupport(); // explicit opt-in - needs to be placed after AddSwaggerGen()
builder.Services.AddAuthentication("ApiKey")
                .AddScheme<ApiKeyAuthenticationSchemeOptions, ApiKeyAuthenticationSchemeHandler>(
                                                                                "ApiKey",
                                                                                        opts => opts.ApiKey = builder.Configuration.GetValue<string>("ApiKey")
                                                                                    );
builder.Services.AddAuthorization();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.MapControllers();

app.Run();