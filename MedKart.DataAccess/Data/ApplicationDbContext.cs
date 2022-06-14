using MedKart.Models;
using Microsoft.EntityFrameworkCore;

namespace MedKart.DataAccess
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base (options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MedicineType> MedicineTypes { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
