using System.Threading.Tasks;

namespace CashbackService.Data;

public interface ICashbackServiceDbSchemaMigrator
{
    Task MigrateAsync();
}
