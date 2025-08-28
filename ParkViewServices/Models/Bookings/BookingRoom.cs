﻿using ParkViewServices.Models.Rooms;

namespace ParkViewServices.Models.Bookings
{
    public class BookingRoom
    {
        public int BookingId { get; set; }
        public Booking Booking { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
