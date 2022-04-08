using System.Collections.Generic;
using System.Linq;

namespace BookingSystem.Domain
{
    public class BookingReciept
    {
        const double DISCOUNT_FOR_4_BOOKINGS = 0.1;
        public IList<Booking> Bookings { get; }
        public BookingReciept(IList<Booking> bookings)
        {
            this.Bookings = bookings;
        }

        public int TotalAmount => Bookings.Sum(x => x.Court.Rate * x.Slots);

        public double Discount => Bookings.Count >= 4 ? TotalAmount * DISCOUNT_FOR_4_BOOKINGS : 0;

        public double TotalAfterDiscount => TotalAmount - Discount;
    }
}