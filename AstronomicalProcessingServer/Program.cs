using AstronomicalProcessingServer;

using CoreWCF.Configuration;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

using ServiceContracts;

var builder = WebHost.CreateDefaultBuilder(args);

builder.UseNetNamedPipe(options =>
{
    options.Listen("net.pipe://localhost");
});

builder.ConfigureServices(services =>
{
    services.AddServiceModelServices();
    services.AddServiceModelMetadata();
});

builder.Configure(configure =>
{
    configure.UseServiceModel(serviceBuilder =>
    {
        serviceBuilder.AddService<AstroServer>();
        serviceBuilder.AddServiceEndpoint<AstroServer, IAstroContract>(
            new CoreWCF.NetNamedPipeBinding(),
            "/AstroService"
        );
    });
});

var app = builder.Build();

app.Run();
