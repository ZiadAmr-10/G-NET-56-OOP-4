namespace Assignment04
{
    internal class Ticket
    {
            public string MovieName { get; set; }
            private decimal price;
            private static int Counter = 0;
            public int TicketId { get; }
            public decimal Price
            {
                get => price;
                set
                {
                    if (value > 0)
                        price = value;
                    else
                        throw new InvalidDataException("Invalid Number ");
                }
            }
            public decimal PriceAfterTax => Price * 1.14m;

            public Ticket(string movieName, decimal price)
            {
                MovieName = movieName;
                Price = price;
                Counter++;
                TicketId = Counter;
            }
            
            public virtual void PrintTicket()
        {
            Console.Write($"Ticket # {TicketId} |{MovieName} | Price: {Price}|After Tax : {PriceAfterTax}");
        }
        public void SetPrice(decimal price) {
            Price = price;
            Console.WriteLine($"Setting Price directly : {price}");
        }
        public void SetPrice(decimal basePrice,decimal multiplier)
        {
            Price = basePrice * multiplier;
            Console.WriteLine($"Setting Price with multiplier : {price} * {multiplier} = {basePrice*multiplier}");
        }
           
          


        }
    }

