﻿using ProductService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductService.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProductServiceController : AbpControllerBase
{
    protected ProductServiceController()
    {
        LocalizationResource = typeof(ProductServiceResource);
    }
}
