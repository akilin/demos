using Api;
using IntegrationTests;
using MailRenderer;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

[assembly: AssemblyFixture(typeof(GlobalTestSetupFixture))]

namespace IntegrationTests;


public class GlobalTestSetupFixture : IAsyncLifetime
{
    public async ValueTask InitializeAsync()
    {
        var app = Program.BuildApp();
        using var scope = app.Services.CreateScope();
        await scope.ServiceProvider.GetRequiredService<MailBodyGenerator>()
            .GenerateEmailConfirmationBody();
    }

    public ValueTask DisposeAsync() => ValueTask.CompletedTask;
}

