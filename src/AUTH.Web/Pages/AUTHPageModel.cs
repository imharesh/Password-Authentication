using AUTH.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AUTH.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AUTHPageModel : AbpPageModel
{
    protected AUTHPageModel()
    {
        LocalizationResourceType = typeof(AUTHResource);
    }
}
