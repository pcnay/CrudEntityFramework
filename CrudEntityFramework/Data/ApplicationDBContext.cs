using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEntityFramework.Data
{
  public class ApplicationDbContext:DbContext
  {
    // Ahora es crear el constructir de la clase.
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
    }

    // Creando el DbSet
    // En esta aprte es donde se agregan las tablas que tiene la base de datos 
    public DbSet<Usuario> Usuario { get; set; }
      

  }
}
