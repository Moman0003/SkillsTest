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
        return $"ID:{ID}, Name:{Name}, Addresse:{Address}, Phone:{Phone},E-mail:{Email}, Total Bookings: {Totalbooking}";
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

    public int Totalbooking
    {
        get
        {
            return bookings.Count;
        }
    }

   // New method: Add a booking with validation
    public void AddBooking(int bookingId, DateTime startTime, DateTime endTime, int participants)
    {
        try
        {
            Booking newBooking = new Booking(bookingId, startTime, endTime, participants);
            ValidateBooking(newBooking); // Validate the new booking
            RegisterBooking(newBooking); // Register the new booking if validation passes
        }
        catch (BookingValidationException ex)
        {
            Console.WriteLine($"Error adding booking: {ex.Message}");
        }
    }

    // Existing method: Validate all bookings
    public void Validate()
    {
        foreach (var booking in bookings.Values)
        {
            if (booking.End < booking.Start)
            {
                string message = $"Error: Booking ID {booking.ID} has End time before Start time. Booking ID {booking.End} is before {booking.Start}.";
                throw new BookingValidationException(message);
            }

            if (!booking.BookingDurationOK)
            {
                string message = $"Error: Booking ID {booking.ID} is more than 2 hours. There is more than 2 hours between {booking.Start} and {booking.End}.";
                throw new BookingValidationException(message);
            }

            if (booking.Participants > 22)
            {
                string message = $"Error: Booking ID {booking.ID} has more than 22 participants. Booking ID {booking.ID} has {booking.Participants} participants.";
                throw new BookingValidationException(message);
            }
        }
    }

    // New method: Validate a single booking
    private void ValidateBooking(Booking booking)
    {
        if (booking.End < booking.Start)
        {
            string message = $"Error: Booking ID {booking.ID} has End time before Start time. Booking ID {booking.End} is before {booking.Start}.";
            throw new BookingValidationException(message);
        }

        if (!booking.BookingDurationOK)
        {
            string message = $"Error: Booking ID {booking.ID} is more than 2 hours. There is more than 2 hours between {booking.Start} and {booking.End}.";
            throw new BookingValidationException(message);
        }

        if (booking.Participants > 22)
        {
            string message = $"Error: Booking ID {booking.ID} has more than 22 participants. Booking ID {booking.ID} has {booking.Participants} participants.";
            throw new BookingValidationException(message);
        }
    }
    
    
    // Method to print all bookings
    public void PrintAllBookings()
    {
        Console.WriteLine($"Bookings for Gymhall {ID} - {Name}:");
        foreach (var booking in bookings.Values)
        {
            Console.WriteLine($"Booking ID: {booking.ID}, Start: {booking.Start}, End: {booking.End}, Participants: {booking.Participants}");
        }
    }

    
    
}