public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override string GetActivityName()
    {
        return "Cycling";
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }

    public override double GetDistance()
    {
        return (_speed * GetDuration()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}