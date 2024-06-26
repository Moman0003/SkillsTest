namespace SkillsTest;

public class Booking
{
    //Properties
    public int ID { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public int Participants { get; set; }
    
    
    //Contructor
    public Booking(int id, DateTime start, DateTime end, int participants)
    {
        ID = id;
        Start = start;
        End = end;
        Participants = participants;
    }
    
    
    //BookingDuration
    public bool BookingDurationOK
    {
        get
        {
            return Start.AddHours(2) >= End;
        }
    }

    public bool IsSundayBooking
    {
        get
        {
            return Start.DayOfWeek == DayOfWeek.Sunday;
        }
    }
    
    
    
    //ToString Method
    public override string ToString()
    {
        return $"Booking ID: {ID}, Start:{Start}, End: {End}, Participants:{Participants}, DurationOK:{BookingDurationOK}, Is Sunday:{IsSundayBooking}";
    }
}
