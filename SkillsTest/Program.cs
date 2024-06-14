namespace SkillsTest;

class Program
{
    static void Main(string[] args)
    {
        Booking booking1 = new Booking(1, new DateTime(2024, 6, 16, 14, 00, 00), new DateTime(2024, 6, 16, 16,00,00),10);
        Booking booking2 = new Booking(2, new DateTime(2024, 6, 22, 14, 00, 00), new DateTime(2024, 6, 21, 16,00,00),15);
        Booking booking3 = new Booking(3, new DateTime(2024, 6, 23, 14, 00, 00), new DateTime(2024, 6, 23, 16,00,00),30);
        

        
        
        
        Gymhall gymhall1 = new Gymhall(101, "Den lille gymnastiksal", "vejeksempel 1, 2860 søborg", "+45 XX XX XX XX",
            "john@doe.com");
        
        Gymhall gymhall2 = new Gymhall(102, "Den store gymnastiksal", "vejeksempel 1, 2860 søborg", "+45 XX XX XX XX",
            "john@doe.com");
        
        Gymhall gymhall3 = new Gymhall(103, "Den mellem gymnastiksal", "vejeksempel 1, 2860 søborg", "+45 XX XX XX XX",
            "john@doe.com");
        
        

        
        
        
        
        Console.WriteLine(gymhall1);
        Console.WriteLine();
       
        Console.WriteLine(gymhall2);
        Console.WriteLine();
        
        Console.WriteLine(gymhall3);
        Console.WriteLine();



        
        
        
        gymhall3.AddBooking(3,new DateTime(2024,6,16,12,00,00), new DateTime(2024,6,16,14,00,00), 10);
        
        Console.WriteLine();
        
        gymhall3.PrintAllBookings();
        
        
        Console.WriteLine(gymhall1);
        Console.WriteLine();
       
        Console.WriteLine(gymhall2);
        Console.WriteLine();
        
        Console.WriteLine(gymhall3);
        Console.WriteLine();
    }
}