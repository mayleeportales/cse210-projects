using System.Data.Common;

public abstract class Activity
{
    private DateTime _date;
    private int _duration;

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    public abstract string GetActivityName();

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetActivityName()} ({_duration} min) - Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace {GetPace():F1} min per km.";
    }
}