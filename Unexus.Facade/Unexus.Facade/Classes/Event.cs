using System;

namespace Unexus.Facade.Classes
{
    public class Event
    {
        public Event() : this(0, string.Empty, DateTime.MinValue, 0, 0) { }

        public Event(int id, string descr, DateTime datetime, int bonusPoint, int comersLimit)
        {
            ID = id;
            Description = descr;
            DateTime = datetime;
            BonusPoint = bonusPoint;
            ComersLimit = comersLimit;
        }

        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public int BonusPoint { get; set; }
        public int ComersLimit { get; set; }
    }
}