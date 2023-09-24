using Microsoft.AspNetCore.Mvc.Controllers;
using Banking.PostgreSQL.Extensions;
using Banking.PostgreSQL.Extensions.CQRS;
using Banking.API.RestModels.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder
    .Services
    .AddBankingData("Host=localhost;Port=5432;Database=banking;Username=postgres;Password=0975695007Dan;")
    .AddValidators()
    .AddClientCommands()
    .AddAccountCommands()
    .AddTransactionCommands()
    .AddTransactionHistoryCommands()
    .AddSQRS();


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.TagActionsBy(api =>
    {
        if (api.GroupName != null)
        {
            return new[] { api.GroupName };
        }

        if (api.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
        {
            return new[] { controllerActionDescriptor.ControllerName };
        }

        throw new InvalidOperationException("Unable to determine tag for endpoint.");
    });

    options.DocInclusionPredicate((name, api) => true);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
