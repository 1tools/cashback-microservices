﻿using System;
using System.Collections.Generic;
using System.Text;
using ProductService.Localization;
using Volo.Abp.Application.Services;

namespace ProductService;

/* Inherit your application services from this class.
 */
public abstract class ProductServiceAppService : ApplicationService
{
    protected ProductServiceAppService()
    {
        LocalizationResource = typeof(ProductServiceResource);
    }
}
