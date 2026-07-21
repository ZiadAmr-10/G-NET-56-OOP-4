namespace Assignment04
{
    internal class VipTicket:Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFees { get; set; }
        public VipTicket(string movieName, decimal price, bool Loungeaccess, decimal Fees) : base(movieName, price)
        {
            LoungeAccess = Loungeaccess;
            ServiceFees = Fees;
        }
        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($",Lounge:{(LoungeAccess ? "Yes" : "No")}, Service Fees: {ServiceFees}");
        }
    }
}
