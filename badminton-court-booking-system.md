# Badminton Court booking system

## Statement

Design a badminton court booking system. The system features are:

1. There are wooden as well as concrete courts in a sports complex.
2. Each booking slot has to be minimum 30 minutes and thereafter multiple of 30 min e.g. 30
min, 60 min, 90 min etc.
3. The sports complex timing is 6 AM to 9 PM
4. Each user gets a receipt of their court bookings for a given day.

For designing following are the considerations:

1. There can be many bookings at the same time
2. Concrete and wooden court have different pricing for 30 min slots
3. Group discount of 10% applies for more than 4 bookings at a time

Expectations:

1. Design entities with proper details
2. Prepare rough flow diagram of booking and receipt printing
 

## Rough work

SportsComplex
    - Courts
    - Bookings


Court 
    {
        rate: 
        type: [Wooden, Concrete]
    }

Booking
    {
        courtId,
        bookingTime: DateTime
        bookingSlots: number (total time is number * 30 minutes)
    }

SportsComplex