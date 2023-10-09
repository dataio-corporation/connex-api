using DataIO.ConneX.API.GraphQl;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();

/*
 * Default connection URI is "http://localhost:5001/graphql"
 * If using an external instance of ConneX, use the replace the Uri with your server:
 *      client => client.BaseAddress = new Uri("http(s)://YOURSERVER/graphql"));
 */

builder.Services.AddConneXGraphQlClient()
    .ConfigureHttpClient(
        client => client.BaseAddress = new Uri("http://localhost:5001/graphql"));


var application = builder.Build();

// Get an instance of the client
var conneXClient = application.Services.GetRequiredService<IConneXGraphQlClient>();

// Make a call to the ConneX GraphQL endpoint
var systems = await conneXClient.GetSystems.ExecuteAsync();

if (systems.Data?.Systems is not null)
{
    foreach (var system in systems.Data.Systems)
    {
        Console.WriteLine($"{system?.Entity?.EntityName}");
    }
}

Console.ReadLine();
