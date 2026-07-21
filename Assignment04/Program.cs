namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Q01
            /*
            -Static binding based on reference -it occurs with method overloading and method hiding -it happens in compile time - execute the method based on  reference
            -Dynamic binding based on object -it occurs with method override and interface -it happens in run time-executes the method based on  object
             */
            #endregion
            #region Q02
            /*
             -Method overloading is a static polymorphism -it happens at compile time -based on refrence-it's the Same method name but
              Different parameter list 
            -Method Overriding is a dynamic polymorphism -it happens at run time -based on object -it's require inheritance - using virtual and override 
             The parent method must be virtual - the same method but different implementation  
             */
            #endregion
            #region Q03
            /*
             The keyword in parent class must be (virtual) to allow to overriding it in child class with keyword (override) 
             to provide a new implementation for the method
            Virtual : Mean Declares a method in the parent class that can be overridden 
            Override : Replaces the parent's virtual method with a new implementation in the child class 
             */
            #endregion
            #endregion
            #region Part 02
            Cinema cinema = new Cinema("Cinema");
            cinema.OpenCinema();
            Console.WriteLine("==========SetPriceTest=========");
            Ticket ticket=new Ticket("inception",50);
            ticket.SetPrice(50);
            ticket.SetPrice(5, 10);
            Console.WriteLine("==========AllTickets=========");
            StandardTicket ticket1 = new StandardTicket("Avengers", 200, "A5");
            cinema.Add(ticket1);
            VipTicket ticket2 = new VipTicket("Spiderman", 300, true, 50);
            cinema.Add(ticket2);
            IMAXTicket ticket3 = new IMAXTicket("Batman", 350, true);
            cinema.Add(ticket3);
            cinema.PrintAllTickets();
            Console.WriteLine("==========Process Single Ticket=========");
            Cinema.ProcessTicket(ticket2);
            cinema.CloseCinema();
            #endregion
        }
    }
}
