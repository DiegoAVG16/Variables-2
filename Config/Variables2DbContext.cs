using Microsoft.EntityFrameworkCore;
using Variables_2.Models;
namespace Variables_2.Config
{
    public class Variables2DbContext:DbContext  

    {
        public Variables2DbContext(DbContextOptions options):base(options) { }

        public DbSet<EmprendedorModel> Emprendedores { get; set; }
             
        }

    
}
