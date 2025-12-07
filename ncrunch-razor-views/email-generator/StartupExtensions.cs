using Microsoft.Extensions.DependencyInjection;

namespace MailRenderer;

public static class StartupExtensions
{
    public static IServiceCollection AddEmailGeneratorServices(this IServiceCollection svc)
    {
        svc.AddRazorPages();
        svc.AddScoped<RazorViewToStringRenderer>();
        svc.AddScoped<MailBodyGenerator>();
        return svc;
    }
}
