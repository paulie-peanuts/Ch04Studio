namespace Ch04Studio
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime DateAdded { get; set; }
        
        public MenuItem(string name, double price, string description, string category)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
        }
        
    }
}