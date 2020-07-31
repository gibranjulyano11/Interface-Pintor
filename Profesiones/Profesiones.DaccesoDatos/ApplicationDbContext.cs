using Microsoft.EntityFrameworkCore;
using Profesiones.Dentidad;

namespace Profesiones.DaccesoDatos
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Pintor> Pintores { get; set; }
    }
}
