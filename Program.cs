using System;

namespace CalendarManagementTool
{
    class Program
    {
        static void Main()
        {
            CalendarManager manager = new CalendarManager();

            while (true)
            {
                Console.WriteLine("\n=== Calendar Management Tool ===");
                Console.WriteLine("1. Add Event");
                Console.WriteLine("2. View All Events");
                Console.WriteLine("3. Search Events by Date");
                Console.WriteLine("4. Delete Event");
                Console.WriteLine("5. Exit");
                Console.Write("Choose: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.AddEvent();
                        break;
                    case "2":
                        manager.ViewEvents();
                        break;
                    case "3":
                        manager.SearchByDate();
                        break;
                    case "4":
                        manager.DeleteEvent();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
