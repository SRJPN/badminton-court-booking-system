using System;
using System.Collections.Generic;
using BookingSystem.Domain;

namespace BookingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var courts = new List<Court>{
                new Court(20, CourtType.Wooden),
                new Court(10, CourtType.Concrete)
            };
            var sportsComplex = new SportsComplex(courts, new DateTime(2022,4,8,6,0,0), new DateTime(2022,4,8,21,0,0));

            var bookingRequest = new List<BookingRequest> {
                new BookingRequest(CourtType.Concrete, DateTime.Now, 1),
                new BookingRequest(CourtType.Wooden, DateTime.Now, 2),
                new BookingRequest(CourtType.Concrete, DateTime.Now, 2),
                new BookingRequest(CourtType.Concrete, DateTime.Now, 3)
            };
            var bookingReciept = sportsComplex.MakeBooking(bookingRequest);

            new Printer().Print(bookingReciept);
        }
    }

    class Printer : IPrinter
    {
        public void Print(CourtType courtType, int rate, DateTime bookingTime, int slots)
        {
            Console.WriteLine($"{courtType.ToString()} {rate} {bookingTime} {slots}");
        }

        public void Print(BookingReciept bookingReciept)
        {
            Console.WriteLine("Bookings");
            bookingReciept.PrintBookings(this.PrintBooking);

            Console.WriteLine("");
            Console.WriteLine($"Total Amount: {bookingReciept.TotalAmount}");
            Console.WriteLine($"Discount: {bookingReciept.Discount}");
            Console.WriteLine($"Total Amount After Discount: {bookingReciept.TotalAfterDiscount}");
        }

        private void PrintBooking(string courtType, DateTime bookingTime, int slots){
            Console.WriteLine($"{courtType}\t{bookingTime}\t{slots}");
        }
    }
}
