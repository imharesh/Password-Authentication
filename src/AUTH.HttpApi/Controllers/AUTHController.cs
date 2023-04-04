using AUTH.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AUTH.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AUTHController : AbpControllerBase
{
    protected AUTHController()
    {
        LocalizationResource = typeof(AUTHResource);
    }
}
