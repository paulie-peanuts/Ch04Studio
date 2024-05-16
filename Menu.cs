namespace Ch04Studio
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public DateTime LastUpdated {get; set; } = System.DateTime.Now;
    }
}