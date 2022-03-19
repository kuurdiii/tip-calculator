using System.ComponentModel.DataAnnotations;
namespace TipCalculator.Models
{
    public class BillModel
    {
        [Required(ErrorMessage = "Please enter your food total")]
        [Range(1, 99999999, ErrorMessage =
            "Food total must be between 1 and 99,999,999")]
        public decimal? FoodTotal { get; set; }

        [Required(ErrorMessage = "Please enter the tax percentage")]
        [Range(0.01, 0.10, ErrorMessage =
            "Tax percentage must be between 0.01 and 0.10")]
        public decimal? TaxPercentage { get; set; }

        [Required(ErrorMessage = "Please enter a tip percentage")]
        [Range(0, 2.0, ErrorMessage =
            "Tip percentage must be between 0 and 2.0")]
        public decimal? TipPercentage { get; set; }
        public decimal? CalculateBillTotal()
        {

            decimal? total_withtax = (FoodTotal + (FoodTotal * TaxPercentage));
            decimal? billTotal = (total_withtax + (total_withtax * TipPercentage));

            return billTotal;
        }
    }
}