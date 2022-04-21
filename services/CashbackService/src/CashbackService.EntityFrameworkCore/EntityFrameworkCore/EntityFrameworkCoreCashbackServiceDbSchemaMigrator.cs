using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CashbackService.Data;
using Volo.Abp.DependencyInjection;

namespace CashbackService.EntityFrameworkCore;

public class EntityFrameworkCoreCashbackServiceDbSchemaMigrator
    : ICashbackServiceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCashbackServiceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the CashbackServiceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CashbackServiceDbContext>()
            .Database
            .MigrateAsync();
    }
}
