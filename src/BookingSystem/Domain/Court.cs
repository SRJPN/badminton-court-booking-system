public class Court
{
   public Court(int rate, CourtType courtType)
    {
        Rate = rate;
        CourtType = courtType;
    }

    public int Rate { get; }

    public CourtType CourtType { get; }
}

public enum CourtType
{
    Wooden,
    Concrete
}