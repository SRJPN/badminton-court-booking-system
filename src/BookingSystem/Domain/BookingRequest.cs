using System;

namespace BookingSystem.Domain
{
    public class BookingRequest
    {
        public BookingRequest(CourtType courtType, DateTime bookingTime, int slots)
        {
            CourtType = courtType;
            BookingTime = bookingTime;
            Slots = slots;
        }

        public CourtType CourtType { get; }
        public DateTime BookingTime { get; }
        public int Slots { get; }
    }
}