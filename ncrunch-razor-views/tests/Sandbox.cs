using System.Threading.Tasks;

namespace IntegrationTests;

public class Sandbox()
{
    [Fact]
    public async Task Test()
    {
        await Task.CompletedTask;
    }
}
