

namespace EstudianteSeguro.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<EstudianteSeguro.Models.Student> Students { get; set; }
    }
}