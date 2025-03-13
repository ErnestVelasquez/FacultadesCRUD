using Microsoft.EntityFrameworkCore;
using FacultadesCRUD.Models;

namespace FacultadesCRUD.Data
{
    public class FacultadContext : DbContext
    {
        public FacultadContext(DbContextOptions<FacultadContext> options) : base(options) { }

        public DbSet<Facultad> Facultades { get; set; }
    }
}