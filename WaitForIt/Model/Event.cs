﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitForIt.Model
{
    public class Event
    {
        public int EventId { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }

        public Event(string EventName, string EventDate)
        {
            this.Name = EventName;
            this.Date = EventDate;
        }
    }
}
