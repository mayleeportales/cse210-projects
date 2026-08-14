public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(DateTime date, int duration, int numberOfLaps) : base(date, duration)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override string GetActivityName()
    {
        return "Swimming";
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000.0;
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetDuration() * 60;
    }
    
}