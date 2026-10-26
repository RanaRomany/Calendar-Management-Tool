using System;

namespace CalendarManagementTool
{
    public class CalendarEvent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public CalendarEvent(int id, string title, DateTime date, string description)
        {
            Id = id;
            Title = title;
            Date = date;
            Description = description;
        }

        public override string ToString()
        {
            return $"ID: {Id} | {Date:yyyy-MM-dd HH:mm} | {Title} | {Description}";
        }
    }
}
