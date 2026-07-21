namespace Assignment04
{
    internal class Cinema
    {
        public string CinemaName { get; set; }
        public Projector Projector { get; }

        Ticket[] tickets = new Ticket[20];
        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
            Projector = new Projector();
        }
        public void Add(Ticket ticket)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = ticket;
                    return;
                }
            }
            Console.WriteLine("Cinema is Full");
        }
        public void PrintAllTickets()
        {
            foreach (var ticket in tickets)
            {
                if(ticket!=null)
                    ticket.PrintTicket();
            }

         }
        public void OpenCinema()
        {
            Console.WriteLine("==========Cinema Opened=========");
            Projector.Start();
        }
        public void CloseCinema()
        {
            Console.WriteLine("========Cinema Closed==========");
            Projector.Stop();
        }
        public static void ProcessTicket(Ticket T)
        {
            T.PrintTicket();
        }
    }
}
