using System;
using System.Collections.Generic;
using System.Text;
using CashbackService.Localization;
using Volo.Abp.Application.Services;

namespace CashbackService;

/* Inherit your application services from this class.
 */
public abstract class CashbackServiceAppService : ApplicationService
{
    protected CashbackServiceAppService()
    {
        LocalizationResource = typeof(CashbackServiceResource);
    }
}
