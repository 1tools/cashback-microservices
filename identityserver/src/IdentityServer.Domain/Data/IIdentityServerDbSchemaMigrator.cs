using System.Threading.Tasks;

namespace IdentityServer.Data;

public interface IIdentityServerDbSchemaMigrator
{
    Task MigrateAsync();
}
