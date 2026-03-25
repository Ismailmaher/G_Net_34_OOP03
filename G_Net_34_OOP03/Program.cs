using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;

namespace G_Net_34_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions



            //Q1: Identify the type of relationship in each scenario below(Inheritance, Association, Aggregation, Composition, or Dependency):

            // a) A University has Departments. If the university is closed, the departments no longer exist.
            //         Composition
            // b) A Driver uses a Car.The driver does not own the car.
            //          Association
            // c) A Dog is an Animal.
            //          Inheritance
            // d) A Team has Players. If the team is deleted, the players still exist.
            //          Aggregation
            // e) A method receives a Logger as a parameter and calls it inside the method only.
            //          Dependency

            //======================================================
            //        Q2: Answer the following questions about access modifiers and sealed:
            //a) A parent class has a protected field.Can a child class in a different assembly access it?
            //What about through an object instance from outside?
            //Yes.A child class  can access a protected field of its parent even if it is located in a different assembly
            //No.You cannot access a protected member via an object instance
            //b) What is the difference between protected internal and private protected?
            // protected internal = same assembly OR child anywhere(more open). 
            //private protected = child in same assembly only(more restrictive).

            //c) What does the sealed keyword do when applied to a class? What about when applied to a method?
            //Prevent unsafe overrides and guarantee behavior consistency
            // When applied to a method: It prevents a derived class from further overriding that specific method.

            //d) Can you create an object from a sealed class using new? Why or why not?
            //Yes, Sealed prevents inheritance, not instantiation. You can still create objects.


            #endregion
            #region Practical 
            //Console.Write("Enter Cinema Name: ");
            //string cinemaName = Console.ReadLine();
            //Cinema myCinema = new Cinema(cinemaName);
            //myCinema.OpenCinema();

            //bool adding = true;
            //while (adding)
            //{
            //    Console.WriteLine("\nChoose Ticket Type: (1) Standard  (2) VIP  (3) IMAX  (0) Finish");
            //    string choice = Console.ReadLine();

            //    if (choice == "0") { adding = false; continue; }

            //    Console.Write("Enter Movie Name: ");
            //    string movie = Console.ReadLine();

            //    Console.Write("Enter Base Price: ");
            //    decimal price = decimal.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case "1":
            //            Console.Write("Enter Seat Number (e.g., A-5): ");
            //            string seat = Console.ReadLine();
            //            myCinema.AddTicket(new StandardTicket(movie, price, seat));
            //            break;

            //        case "2":
            //            Console.Write("Lounge Access? (yes/no): ");
            //            bool lounge = Console.ReadLine().ToLower() == "yes";
            //            myCinema.AddTicket(new VIPTicket(movie, price, lounge));
            //            break;

            //        case "3":
            //            Console.Write("Is it 3D? (yes/no): ");
            //            bool is3D = Console.ReadLine().ToLower() == "yes";
            //            myCinema.AddTicket(new IMAXTicket(movie, price, is3D));
            //            break;

            //        default:
            //            Console.WriteLine("Invalid choice!");
            //            break;
            //    }
            //}
            //myCinema.PrintAllTickets();

            //Console.WriteLine("\n========== Statistics ==========");
            //Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}\n");

            //myCinema.PrintExtraDetails(5, 100);

            //myCinema.CloseCinema();



            //Console.WriteLine("\nPress any key to exit...");
            //Console.ReadKey();


            #endregion

            #region Cinema
            //public class Projector
            //{
            //    public void Start() => Console.WriteLine("Projector started.");
            //    public void Stop() => Console.WriteLine("Projector stopped.");
            //}

            //public class Cinema
            //{
            //    public string CinemaName { get; set; }
            //    private Projector _projector;
            //    private Ticket[] _tickets = new Ticket[20];
            //    private int _ticketCount = 0;

            //    public Cinema(string name)
            //    {
            //        CinemaName = name;
            //        _projector = new Projector();
            //    }

            //    public void AddTicket(Ticket t)
            //    {
            //        if (_ticketCount < 20) _tickets[_ticketCount++] = t;
            //    }

            //    public void PrintAllTickets()
            //    {
            //        Console.WriteLine("\n========== All Tickets ==========");
            //        for (int i = 0; i < _ticketCount; i++)
            //        {
            //            Console.WriteLine(_tickets[i].ToString());
            //        }
            //    }

            //    public void OpenCinema()
            //    {
            //        Console.WriteLine("========== Cinema Opened ==========");
            //        _projector.Start();
            //    }

            //    public void CloseCinema()
            //    {
            //        Console.WriteLine("\n========== Cinema Closed ==========");
            //        _projector.Stop();
            //    }

            //    public void PrintExtraDetails(int groupTicketsCount, decimal pricePerTicket)
            //    {

            //        if (_ticketCount >= 1) Console.WriteLine($"Booking Ref 1: BK-{_tickets[0].TicketId}");
            //        if (_ticketCount >= 2) Console.WriteLine($"Booking Ref 2: BK-{_tickets[1].TicketId}");

            //        Console.WriteLine(); 

            //        decimal totalBeforeDiscount = groupTicketsCount * pricePerTicket;
            //        decimal discount = totalBeforeDiscount * 0.10m; 
            //        decimal totalAfterDiscount = totalBeforeDiscount - discount;

            //        Console.WriteLine($"Group Discount ({groupTicketsCount} x {pricePerTicket} EGP): {totalAfterDiscount} EGP (10% off)");
            //    }

            //}
            #endregion

            #region three child classes

            //public class StandardTicket : Ticket
            //{
            //    public string SeatNumber { get; set; }
            //    public StandardTicket(string movie, decimal price, string seat) : base(movie, price) => SeatNumber = seat;

            //    public override string ToString() => base.ToString() + $" | Seat: {SeatNumber}";


            //}

            //public class VIPTicket : Ticket
            //{
            //    public bool LoungeAccess { get; set; }
            //    public decimal ServiceFee { get; } = 50;
            //    public VIPTicket(string movie, decimal price, bool lounge) : base(movie, price) => LoungeAccess = lounge;
            //    public override string ToString() => base.ToString() + $" | Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP";
            //}

            //public class IMAXTicket : Ticket
            //{
            //    public bool Is3D { get; set; }
            //    public IMAXTicket(string movie, decimal price, bool is3D) : base(movie, price)
            //    {
            //        Is3D = is3D;
            //        if (Is3D) Price += 30;
            //    }

            //    public override string ToString() => base.ToString() + $" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
            //}


            #endregion

            #region Ticket

            //public class Ticket
            //{
            //    private static int _ticketCounter = 0;
            //    public string MovieName { get; set; }
            //    private decimal _price;
            //    public int TicketId { get; }
            //    public decimal Price
            //{
            //    get => _price;
            //        set
            //        {
            //            if (value > 0)
            //            {
            //                _price = value;
            //                Console.WriteLine($"Price updated successfully to: {value}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Error: Attempted to set a non-positive price.");
            //                Console.WriteLine("Price must be > 0");
            //            }
            //        }
            //    }
            //    public decimal PriceAfterTax => Price * 1.14m;
            //    public Ticket(string movieName, decimal price)
            //    {
            //        TicketId = ++_ticketCounter;
            //        MovieName = movieName;
            //        Price = price;
            //    }
            //    public static int GetTotalTickets() => _ticketCounter;

            //    public override string ToString()
            //    {
            //        return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
            //    }
            //}
            #endregion
        }
    }
}
