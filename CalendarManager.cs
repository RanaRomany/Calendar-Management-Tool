using System;
using System.Collections.Generic;
using System.Linq;

namespace CalendarManagementTool
{
    public class CalendarManager
    {
        private readonly List<CalendarEvent> events = new List<CalendarEvent>();

        public void AddEvent()
        {
            Console.Write("Enter event ID: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            if (events.Any(e => e.Id == id))
            {
                Console.WriteLine("This ID already exists.");
                return;
            }

            Console.Write("Enter title: ");
            string title = Console.ReadLine();

            Console.Write("Enter date and time (yyyy-MM-dd HH:mm): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                Console.WriteLine("Invalid date.");
                return;
            }

            Console.Write("Enter description: ");
            string description = Console.ReadLine();

            events.Add(new CalendarEvent(id, title, date, description));
            Console.WriteLine("Event added successfully.");
        }

        public void ViewEvents()
        {
            if (events.Count == 0)
            {
                Console.WriteLine("No events found.");
                return;
            }

            Console.WriteLine("\n--- All Events ---");

            foreach (CalendarEvent calendarEvent in events.OrderBy(e => e.Date))
            {
                Console.WriteLine(calendarEvent);
            }
        }

        public void SearchByDate()
        {
            Console.Write("Enter date (yyyy-MM-dd): ");

            if (!DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                Console.WriteLine("Invalid date.");
                return;
            }

            var results = events
                .Where(e => e.Date.Date == date.Date)
                .OrderBy(e => e.Date)
                .ToList();

            if (results.Count == 0)
            {
                Console.WriteLine("No events found on this date.");
                return;
            }

            Console.WriteLine("\n--- Events on " + date.ToString("yyyy-MM-dd") + " ---");

            foreach (CalendarEvent calendarEvent in results)
            {
                Console.WriteLine(calendarEvent);
            }
        }

        public void DeleteEvent()
        {
            Console.Write("Enter event ID to delete: ");

            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            CalendarEvent eventToDelete = events.FirstOrDefault(e => e.Id == id);

            if (eventToDelete == null)
            {
                Console.WriteLine("Event not found.");
                return;
            }

            events.Remove(eventToDelete);
            Console.WriteLine("Event deleted successfully.");
        }
    }
}
