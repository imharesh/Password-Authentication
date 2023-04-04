using System;
using System.Collections.Generic;
using System.Text;
using AUTH.Localization;
using Volo.Abp.Application.Services;

namespace AUTH;

/* Inherit your application services from this class.
 */
public abstract class AUTHAppService : ApplicationService
{
    protected AUTHAppService()
    {
        LocalizationResource = typeof(AUTHResource);
    }
}
