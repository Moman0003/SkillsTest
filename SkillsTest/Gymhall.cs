namespace SkillsTest;

public class Gymhall
{
    //Properties
    public int ID { get; set; }
    public string Name { get; set; } 
    public string Address { get; set; } 
    public string Phone { get; set; } 
    public string Email { get; set; } 
    
    private Dictionary<int, Booking> bookings;
    
    //Contructor

    public Gymhall(int id, string name, string address, string phone, string email)
    {
        ID = id;
        Name = name;
        Address = address;
        Phone = phone;
        Email = email;
        bookings = new Dictionary<int, Booking>();
    }

    //ToString Method
    public override string ToString()
    {
        return $"ID:{ID}, Name:{Name}, Addresse:{Address}, Phone:{Phone},E-mail:{Email}";
    }
    
    
    // CRUD register a booking
    public void RegisterBooking(Booking booking)
    {
        if (!bookings.ContainsKey(booking.ID))
        {
            bookings.Add(booking.ID, booking);
            Console.WriteLine($"Booking {booking.ID} added successfully.");
        }
        else
        {
            Console.WriteLine($"Booking ID {booking.ID} already exists.");
        }
    }
    
    // CRUD print all bookings
    public void PrintBookings()
    {
        foreach (var booking in bookings.Values)
        {
            Console.WriteLine(booking);
        }
    }

    //CRUD remove a booking
    public void RemoveBooking(Booking booking)
    {
        if (bookings.ContainsKey(booking.ID))
        {
            bookings.Remove(booking.ID);
            Console.WriteLine($"Booking {booking.ID} removed successfully.");
        }
        else
        {
            Console.WriteLine($"Booking ID {booking.ID} not found.");
        }
    }
    
    
}