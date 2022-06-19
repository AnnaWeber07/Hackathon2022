namespace Unexus.Facade.Classes
{
    public class Fines
    {
        public Fines() : this(0, new User(), 0) { }

        public Fines(int id, User user, int finesPointAmount)
        {
            ID = id;
            User = user;
            FinesPointAmount = finesPointAmount;
        }

        public int ID { get; set; }
        public User User { get; set; }
        public int FinesPointAmount { get; set; }
    }
}
