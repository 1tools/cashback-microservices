using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ProductService.Data;

/* This is used if database provider does't define
 * IProductServiceDbSchemaMigrator implementation.
 */
public class NullProductServiceDbSchemaMigrator : IProductServiceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
