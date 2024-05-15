

namespace Ch04Studio
{
    public class Menu
    {
        private List<MenuItem> MenuItems { get; } = [];
        private DateTime lastUpdated {get; set; } = System.DateTime.Now;
    }
}