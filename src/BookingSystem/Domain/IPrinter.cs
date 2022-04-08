using System;
using BookingSystem.Domain;

public interface IPrinter
{
    void Print(CourtType courtType, int rate, DateTime bookingTime, int slots);

    void Print(BookingReciept bookingReciept);
}