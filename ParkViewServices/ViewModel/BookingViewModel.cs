﻿namespace ParkViewServices.ViewModel
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Microsoft.AspNetCore.Mvc.Rendering;
	using ParkViewServices.Helpers;
	using ParkViewServices.Models.Hotels;

    public class BookingViewModel
    {
        [Required(ErrorMessage = "Please select a hotel.")]
        [Display(Name = "Select Hotel")]
        public int HotelId { get; set; } = 1;

		[Required(ErrorMessage = "Please select the check-in date.")]
		[DataType(DataType.Date)]
		[Display(Name = "Check-In Date")]
		[CheckInDateValidation(ErrorMessage = "Check-In Date must be between today and 3 months from today.")]
		public DateTime CheckInDate { get; set; } = DateTime.Now;

		[Required(ErrorMessage = "Check-out date is required.")]
		[DataType(DataType.Date)]
		[DateGreaterThan(ErrorMessage = "CheckOut Date must be at least one day after CheckIn Date.")]
		public DateTime CheckOutDate { get; set; } = DateTime.Now.AddDays(1);

        [Range(1, int.MaxValue, ErrorMessage = "Please select the number of rooms.")]
        [Display(Name = "Number of Rooms")]
        public int NumberOfRooms { get; set; } = 2;

        [Range(1, int.MaxValue, ErrorMessage = "Please select the number of guests.")]
        [Display(Name = "Number of Guests")]
        public int NumberOfGuests { get; set; } = 2;

        [Range(0, int.MaxValue, ErrorMessage = "Please select the number of guests.")]
        [Display(Name = "Number of Children")]
        public int NumberOfChildren7to12 { get; set; } = 2;

        [BindNever]
        public SelectList Hotels { get; set; }

        

    }

}
