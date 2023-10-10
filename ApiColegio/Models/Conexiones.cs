using Microsoft.EntityFrameworkCore;
using ApiColegio.Models;
namespace ApiColegio.Models;
public class Conexiones : DbContext{
    public Conexiones(DbContextOptions<Conexiones> options)
        : base(options)
    {
    }

    public DbSet<Estudiantes> Estudiantes { get; set; } = null!;
    public DbSet<Estudiantes> Tipos_sangre { get; set; } = null!;

}