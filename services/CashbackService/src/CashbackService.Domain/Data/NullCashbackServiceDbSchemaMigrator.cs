using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CashbackService.Data;

/* This is used if database provider does't define
 * ICashbackServiceDbSchemaMigrator implementation.
 */
public class NullCashbackServiceDbSchemaMigrator : ICashbackServiceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
