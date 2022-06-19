namespace Unexus.Facade.Classes
{
    public class Role
    {
        public Role() : this(0, string.Empty) { }

        public Role(int id, string descr)
        {
            ID = id;
            Descr = descr;
        }

        public int ID { get; set; }
        public string Descr { get; set; }
    }
}
