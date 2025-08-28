namespace ParkViewServices.Helpers
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class DateGreaterThanAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			var checkInDate = (DateTime)validationContext.ObjectType.GetProperty("CheckInDate").GetValue(validationContext.ObjectInstance, null);
			var checkOutDate = (DateTime)value;

			if (checkOutDate <= checkInDate.AddHours(12))
			{
				return new ValidationResult(ErrorMessage);
			}

			return ValidationResult.Success;
		}

	}
}
