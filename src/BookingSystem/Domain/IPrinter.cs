using System;

public interface IPrinter
{
    void Print(CourtType courtType, int rate, DateTime bookingTime, int slots);
}