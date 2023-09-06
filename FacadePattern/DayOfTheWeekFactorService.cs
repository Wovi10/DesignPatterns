namespace FacadePattern;

public class DayOfTheWeekFactorService
{
    public double CalculateDayOfTheWeekFactor()
    {
        return DateTime.UtcNow.DayOfWeek switch
        {
            DayOfWeek.Saturday => 0.8,
            DayOfWeek.Sunday => 0.8,
            _ => 1.2
        };
    }
}