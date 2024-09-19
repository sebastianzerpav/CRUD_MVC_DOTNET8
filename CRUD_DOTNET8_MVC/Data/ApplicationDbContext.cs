using CRUD_DOTNET8_MVC.Models;  
using Microsoft.EntityFrameworkCore;

namespace CRUD_DOTNET8_MVC.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { 
        }

        //Agregar modelos
        public DbSet<Contacto> contactos { get; set; }
    }
}
