using System.Data.Entity;

namespace Service
{
    public class CarDbInitializer : DropCreateDatabaseIfModelChanges<CarContext>
    {
        protected override void Seed(CarContext context)
        {
            context.Cars.Add(new Car { CarId = 1, Model = "BMW", Name = "530", Price = 40000 });
            base.Seed(context);
        }
    }
}