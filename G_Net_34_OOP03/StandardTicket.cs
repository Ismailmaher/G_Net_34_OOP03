using System;
using System.Collections.Generic;
using System.Text;

namespace G_Net_34_OOP03
{
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

}
