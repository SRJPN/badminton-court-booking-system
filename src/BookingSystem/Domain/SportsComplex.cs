using System;
using System.Collections.Generic;
using System.Linq;
using BookingSystem.Domain;

public class SportsComplex
{
    const int SLOT_TIME_IN_MINUTES = 30;
    private readonly IList<Court> courts;
    private readonly DateTime openingTime;
    private readonly DateTime closingTime;

    public SportsComplex(IList<Court> courts, DateTime openingTime, DateTime closingTime)
    {
        this.closingTime = closingTime;
        this.openingTime = openingTime;
        this.courts = courts;
    }

    public readonly IList<Booking> bookings = new List<Booking>();

    public Booking MakeBooking(CourtType courtType, DateTime bookingTime, int noOfSlots)
    {
        if( openingTime > bookingTime || closingTime < bookingTime.AddMinutes(SLOT_TIME_IN_MINUTES * noOfSlots)) {
            throw new Exception("Booking time beyond working hours");
        }
        var court = courts.First(court => court.CourtType == courtType);
        var booking = new Booking(court, bookingTime, noOfSlots);
        bookings.Add(booking);
        return booking;
    }

    public BookingReciept MakeBooking(IList<BookingRequest> bookingRequests)
    {
        var bookings = bookingRequests.Select(bookingRequest => MakeBooking(bookingRequest.CourtType, bookingRequest.BookingTime, bookingRequest.Slots));
        var bookingReciept = new BookingReciept(bookings.ToList());
        return bookingReciept;
    }
}