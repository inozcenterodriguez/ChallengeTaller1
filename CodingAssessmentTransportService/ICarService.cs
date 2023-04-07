namespace CodingAssessmentTransportService
{
    public interface ICarService
    {
        Task<List<Car>> GetCarsAsync();
        Task<Car> GetCarByIdAsync(int id);
        Task CreateCarAsync(Car car);
        Task UpdateCarAsync(Car car);
        Task DeleteCarAsync(int id);
    }
}