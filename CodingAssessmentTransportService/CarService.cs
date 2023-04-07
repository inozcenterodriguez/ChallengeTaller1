namespace CodingAssessmentTransportService
{
    public class CarService : ICarService
    {
        private List<Car> cars;

        public CarService()
        { 
            cars = new List<Car>{
        new Car { Id = 1, Make = "Audi", Model = "R8", Year = 2018, Doors = 2, Color = "Red", Price = 79995 },
        new Car { Id = 2, Make = "Tesla", Model = "3", Year = 2018, Doors = 4, Color = "Black", Price = 54995 },
        new Car { Id = 3, Make = "Porsche", Model = "911 991", Year = 2020, Doors = 2, Color = "White", Price = 155000 },
        new Car { Id = 4, Make = "Mercedes-Benz", Model = "GLE 63S", Year = 2021, Doors = 5, Color = "Blue", Price = 83995 },
        new Car { Id = 5, Make = "BMW", Model = "X6 M", Year = 2020, Doors = 5, Color = "Silver", Price = 62995 }
    };
    }

        public async Task<List<Car>> GetCarsAsync()
        {
            return await Task.Run(() => cars);
        }

        public async Task<Car> GetCarByIdAsync(int id)
        {
            return await Task.Run(() =>
            {
                foreach (Car car in cars)
                {
                    if (car.Id == id)
                    {
                        return car;
                    }
                }
                return null;
            });
        }

        public async Task CreateCarAsync(Car car)
        {
            await Task.Run(() =>
            {
                cars.Add(car);
            });
        }

        public async Task UpdateCarAsync(Car carToUpdate)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Id == carToUpdate.Id)
                    {
                        cars[i] = carToUpdate;
                        break;
                    }
                }
            });
        }

        public async Task DeleteCarAsync(int id)
        {
            await Task.Run(() =>
            {
               var DeleteCar = cars.Where(x => x.Id == id).FirstOrDefault();

                if (DeleteCar != null)
                {
                    cars.Remove(DeleteCar);

                }
                 
 
            });
        }
    }

}
