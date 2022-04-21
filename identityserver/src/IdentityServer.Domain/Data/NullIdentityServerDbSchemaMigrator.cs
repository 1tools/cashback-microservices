using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace IdentityServer.Data;

/* This is used if database provider does't define
 * IIdentityServerDbSchemaMigrator implementation.
 */
public class NullIdentityServerDbSchemaMigrator : IIdentityServerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
