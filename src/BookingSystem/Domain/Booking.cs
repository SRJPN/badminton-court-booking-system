using System;

public class Booking
{
    public Booking(Court court, DateTime bookingTime, int slots)
    {
        this.Court = court;
        this.BookingTime = bookingTime;
        this.Slots = slots;

    }
    public Court Court { get; }

    public DateTime BookingTime { get; }

    public int Slots { get; }

    public void Print(IPrinter printer) {
        printer.Print(this.Court.CourtType, this.Court.Rate, this.BookingTime, this.Slots);
    }
}