using System.Data.Entity;

namespace Service
{
    public class CarContext:DbContext
    {
        public CarContext() : base("CarDataBase") { }
        public DbSet<Car> Cars { get; set; }
    }
}