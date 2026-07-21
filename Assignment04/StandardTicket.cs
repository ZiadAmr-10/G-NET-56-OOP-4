namespace Assignment04
{
    internal class StandardTicket:Ticket
    {
        public string SeatNumber { get; set; }
        public StandardTicket(string movieName, decimal price, string Seatnumber) : base(movieName, price)
        {
            SeatNumber = Seatnumber;
        }
        public override void PrintTicket()
        {
           base.PrintTicket();
            Console.WriteLine($",SeatNumber{SeatNumber}"); 
        }
    }
}
