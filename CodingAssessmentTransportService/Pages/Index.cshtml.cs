using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodingAssessmentTransportService.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICarService _carService;

        public IndexModel(ICarService carService)
        {
            _carService = carService;
        }

        public List<Car> Cars { get; set; }

        [BindProperty]
        public int SelectedCarId { get; set; }

        [BindProperty]
        public decimal GuessedPrice { get; set; }

        public string Message { get; set; }

        public async Task OnGetAsync()
        {
            Cars = await _carService.GetCarsAsync();
        }

        public async Task  OnPostAsync(object s )
        {
            Cars = await _carService.GetCarsAsync();

            var selectedCar = await _carService.GetCarByIdAsync(SelectedCarId);

            if (selectedCar != null)
            {
                if (Math.Abs(selectedCar.Price - GuessedPrice) <= 5000)
                {
                    Message = "Great job! ";
                }
                else
                {
                    Message = "Wrong answer , Try Again";
                }
            }
            else
            {
                Message = "Car ID not Found";
            }
               
        }
    }

}