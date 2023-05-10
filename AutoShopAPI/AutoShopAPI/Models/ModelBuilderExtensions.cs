using Microsoft.EntityFrameworkCore;

namespace AutoShopAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer { Id = 1, Name = "Chevrolet" },
                new Manufacturer { Id = 2, Name = "Ford" },
                new Manufacturer { Id = 3, Name = "GMC" },
                new Manufacturer { Id = 4, Name = "Renault" });

            modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, ManufacturerId = 1, Vin = "4Y1SL65848Z411896", Model = "Suburban", Year = "2019", Price = 60000, IsAvailable = true },
                new Car { Id = 2, ManufacturerId = 1, Vin = "4Y1SL65848Z411439", Model = "Tahoe", Year = "2020", Price = 50000, IsAvailable = true },
                new Car { Id = 3, ManufacturerId = 1, Vin = "4Y1SL65848Z417458", Model = "Spark", Year = "2021", Price = 20000, IsAvailable = true },
                new Car { Id = 4, ManufacturerId = 1, Vin = "4Y1SL65848Z413659", Model = "Equinox", Year = "2022", Price = 25000, IsAvailable = true },
                new Car { Id = 5, ManufacturerId = 1, Vin = "4Y1SL65848Z414545", Model = "Traverse", Year = "2023", Price = 15000, IsAvailable = true },
                new Car { Id = 6, ManufacturerId = 2, Vin = "4Y1SL65848Z419696", Model = "Fiesta", Year = "2019", Price = 60000, IsAvailable = true },
                new Car { Id = 7, ManufacturerId = 2, Vin = "4Y1SL65848Z417423", Model = "Focus", Year = "2020", Price = 50000, IsAvailable = true },
                new Car { Id = 8, ManufacturerId = 2, Vin = "4Y1SL65848Z414222", Model = "Fusion", Year = "2021", Price = 20000, IsAvailable = true },
                new Car { Id = 9, ManufacturerId = 2, Vin = "4Y1SL65848Z419899", Model = "Escape", Year = "2022", Price = 25000, IsAvailable = true },
                new Car { Id = 10, ManufacturerId = 2, Vin = "4Y1SL65848Z413030", Model = "Mustang", Year = "2023", Price = 15000, IsAvailable = true },
                new Car { Id = 11, ManufacturerId = 3, Vin = "4Y1SL65848Z415555", Model = "Sierra", Year = "2019", Price = 60000, IsAvailable = true },
                new Car { Id = 12, ManufacturerId = 3, Vin = "4Y1SL65848Z416363", Model = "Yukon", Year = "2020", Price = 50000, IsAvailable = true },
                new Car { Id = 13, ManufacturerId = 3, Vin = "4Y1SL65848Z417789", Model = "Acadia", Year = "2021", Price = 40000, IsAvailable = true },
                new Car { Id = 14, ManufacturerId = 3, Vin = "4Y1SL65848Z417743", Model = "Canyon", Year = "2022", Price = 30000, IsAvailable = true },
                new Car { Id = 15, ManufacturerId = 3, Vin = "4Y1SL65848Z419732", Model = "Terrain", Year = "2023", Price = 20000, IsAvailable = true },
                new Car { Id = 16, ManufacturerId = 4, Vin = "4Y1SL65848Z410937", Model = "Clio", Year = "2019", Price = 15000, IsAvailable = true },
                new Car { Id = 17, ManufacturerId = 4, Vin = "4Y1SL65848Z418960", Model = "Megane", Year = "2020", Price = 50000, IsAvailable = true },
                new Car { Id = 18, ManufacturerId = 4, Vin = "4Y1SL65848Z411596", Model = "Sandero", Year = "2021", Price = 40000, IsAvailable = true },
                new Car { Id = 19, ManufacturerId = 4, Vin = "4Y1SL65848Z414585", Model = "Arkana", Year = "2022", Price = 30000, IsAvailable = true },
                new Car { Id = 20, ManufacturerId = 4, Vin = "4Y1SL65848Z410926", Model = "Captur", Year = "2023", Price = 20000, IsAvailable = true });
        }
    }
}
