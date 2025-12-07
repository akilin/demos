using MailRenderer;
using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;

namespace Api;

public class Program
{
    public static async Task<int> Main(string[] args)
    {
        var app = BuildApp();

        await app.RunAsync();

        return 0;
    }

    public static WebApplication BuildApp()
    {
        var builder = WebApplication.CreateBuilder();
        builder.Services.AddEmailGeneratorServices();
        return builder.Build();
    }
}
