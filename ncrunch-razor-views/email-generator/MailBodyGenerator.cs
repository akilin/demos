using MailRenderer.Views.Emails.EmailConfirmation;
using System.Threading.Tasks;

namespace MailRenderer;

public record GeneratedEmail(string Subject, string Body);

public class MailBodyGenerator(RazorViewToStringRenderer renderer)
{
    public async Task<GeneratedEmail> GenerateEmailConfirmationBody()
    {
        var url = $"https://example.com";
        var model = new EmailConfirmationViewModel(url);
        var body = await renderer.RenderViewToStringAsync("/Views/Emails/EmailConfirmation/EmailConfirmation.cshtml", model);
        return new("SomeString", body);
    }
}
