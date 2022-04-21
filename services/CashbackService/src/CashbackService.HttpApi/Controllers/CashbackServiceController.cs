using CashbackService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CashbackService.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CashbackServiceController : AbpControllerBase
{
    protected CashbackServiceController()
    {
        LocalizationResource = typeof(CashbackServiceResource);
    }
}
