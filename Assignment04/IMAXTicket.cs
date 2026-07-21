namespace Assignment04
{
    internal class IMAXTicket:Ticket
    {
        public bool Is3D { get; set; }
        public IMAXTicket(string movieName, decimal price, bool is3d) : base(movieName, price)
        {
            Is3D = is3d;
        }
        public decimal PriceAfter3D => Is3D ? PriceAfterTax + 30 : Price;
        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($",3D:{(Is3D ? $"Yes + (30) Price :{PriceAfter3D}" : "No")}");
        }
    }
}
