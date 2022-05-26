using CrudEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudEFCore.Datos
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        //Agregar todos los modelos aquí
        //(localDb)\MSSQLLocalDB
        public DbSet<Usuario> Usuario { get; set; }
    }
}
