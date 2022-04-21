using System.Threading.Tasks;

namespace ProductService.Data;

public interface IProductServiceDbSchemaMigrator
{
    Task MigrateAsync();
}
