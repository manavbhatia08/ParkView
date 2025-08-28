using System.ComponentModel.DataAnnotations;

namespace ParkViewServices.Helpers
{
	public class CheckInDateValidationAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			var checkInDate = (DateTime)value;
			var today = DateTime.Today;
			var threeMonthsFromToday = today.AddMonths(3);

			if (checkInDate < today || checkInDate > threeMonthsFromToday)
			{
				return new ValidationResult(ErrorMessage);
			}

			return ValidationResult.Success;
		}
	}
}
