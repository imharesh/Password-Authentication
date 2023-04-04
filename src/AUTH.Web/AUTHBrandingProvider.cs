using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AUTH.Web;

[Dependency(ReplaceServices = true)]
public class AUTHBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AUTH";
}
