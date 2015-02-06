using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitForIt.Model
{
    public class Event
    {
        public static ObservableCollection<Event> Events = new ObservableCollection<Event>();

        public string Date;
        public string Name;

        public Event(string EventName, string EventDate)
        {
            this.Name = EventName;
            this.Date = EventDate;
            Events.Add(this);
        }
    }
}
