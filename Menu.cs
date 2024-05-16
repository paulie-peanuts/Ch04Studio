using System.Text;

namespace Ch04Studio
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public DateTime LastUpdated {get; set; } = System.DateTime.Now;
        public void AddItem(MenuItem newItem)
        {
            MenuItems.Add(newItem);
            LastUpdated = DateTime.Now;
            newItem.DateAdded = DateTime.Now;
        }
        public void RemoveItem(MenuItem item)
        {
            MenuItems.Remove(item);
            LastUpdated = DateTime.Now;
        }
        public override string ToString()
        {
            StringBuilder total = new();
            foreach (MenuItem item in MenuItems)
            {
                total.Append(Environment.NewLine).Append(item).Append(Environment.NewLine).Append("--");

            }
            return "-----FOOD----" + total;
        }
    }
}