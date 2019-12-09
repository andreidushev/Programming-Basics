using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();

            int standard = 0;
            int kid = 0;
            int student = 0;
            int totalTicketCounter = 0;
            

            while (movieName != "Finish")
            {
                int tickets = int.Parse(Console.ReadLine());
                int ticketCounter = 0;

                for (int i = 0; i < tickets; i++)
                {
                    string ticketType = Console.ReadLine();
                    
                    switch (ticketType)
                    {
                        case "standard":
                            standard++;
                            ticketCounter++;
                            break;
                        case "kid":
                            ticketCounter++;
                            kid++;
                            break;
                        case "student":
                            ticketCounter++;
                            student++;
                            break;
                    }
                    if (ticketType == "End")
                    {
                        break;
                    }
                }
                double percentField = ((double)ticketCounter / tickets) * 100;
                Console.WriteLine($"{movieName} - {percentField:F2}% full.");
                totalTicketCounter += ticketCounter;
                movieName = Console.ReadLine();
            }
            double studentPercent = ((double)student / totalTicketCounter) * 100;
            double standardPercent = ((double)standard / totalTicketCounter) * 100;
            double kidPercent = ((double)kid / totalTicketCounter) * 100;
            
            Console.WriteLine($"Total tickets: {totalTicketCounter}");
            Console.WriteLine($"{studentPercent:F2}% student tickets.");
            Console.WriteLine($"{standardPercent:F2}% standard tickets.");
            Console.WriteLine($"{kidPercent:F2}% kids tickets.");
        }
    }
}
