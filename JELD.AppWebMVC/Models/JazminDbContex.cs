using Microsoft.EntityFrameworkCore;

namespace JELD.AppWebMVC.Models
{
    public class JazminDbContex : DbContext
    {
        public JazminDbContex(DbContextOptions<JazminDbContex> options) : base(options) { }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }

    }
}
