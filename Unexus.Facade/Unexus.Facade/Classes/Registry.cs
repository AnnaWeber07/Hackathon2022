using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unexus.Facade.Classes
{
    public class Registry
    {
        public Registry() : this(0, new Event(), new User()) { }

        public Registry(int id, Event evt, User comer)
        {
            ID = ID;
            Evt = evt;
            Comer = comer;
        }

        public int ID { get; set; }
        public Event Evt { get; set; }
        public User Comer { get; set; }
    }
}
