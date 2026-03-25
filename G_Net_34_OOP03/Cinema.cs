using System;
using System.Collections.Generic;
using System.Text;

namespace G_Net_34_OOP03
{
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
}
