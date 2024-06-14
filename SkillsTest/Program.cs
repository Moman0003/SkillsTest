namespace SkillsTest;

class Program
{
    static void Main(string[] args)
    {
        Booking booking1 = new Booking(1, new DateTime(2024, 6, 21, 14, 00, 00), new DateTime(2024, 6, 21, 16,00,00),10);
        Booking booking2 = new Booking(2, new DateTime(2024, 6, 22, 14, 00, 00), new DateTime(2024, 6, 22, 16,00,00),15);
        Booking booking3 = new Booking(3, new DateTime(2024, 6, 23, 14, 00, 00), new DateTime(2024, 6, 23, 16,00,00),20);

        Gymhall gymhall1 = new Gymhall(101, "Den lille gymnastiksal", "vejeksempel 1, 2860 søborg", "+45 XX XX XX XX",
            "john@doe.com");
        
        Gymhall gymhall2 = new Gymhall(102, "Den store gymnastiksal", "vejeksempel 1, 2860 søborg", "+45 XX XX XX XX",
            "john@doe.com");
        
        
        Console.WriteLine(gymhall1);
        
        
        gymhall1.RegisterBooking(booking1);
        
        Console.WriteLine("Bookings i Den Lille Gymnastiksal");
        gymhall1.PrintBookings();

        
        Console.WriteLine();
        
        Console.WriteLine("Bookings i Den Store Gymnastiksal");
        gymhall2.RegisterBooking(booking2);
        gymhall2.PrintBookings(); 
        
        
    }
}