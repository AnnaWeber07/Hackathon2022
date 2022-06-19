using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unexus.Facade.Classes
{
    public class User
    {
        public User() : this(0, string.Empty, string.Empty, new Role(), 0) { }

        public User(int id, string name, string password, Role role, int bonusPoint)
        {
            ID = id;
            Name = name;
            Password = password;
            Role = role;
            BonusPoint = bonusPoint;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public int BonusPoint { get; set; }
    }
}
