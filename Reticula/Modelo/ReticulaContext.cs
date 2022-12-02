using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Reticula.Modelo {
    public class ReticulaContext :DbContext{

        public ReticulaContext(DbContextOptions<ReticulaContext> options):base(options) {
            try {
                var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if (databaseCreator != null) {
                    if (!databaseCreator.CanConnect()) 
                        databaseCreator.Create();
                    if (!databaseCreator.HasTables()) 
                        databaseCreator.CreateTables();
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }


        public DbSet<Materia> Materias { get; set; }
    }
}
