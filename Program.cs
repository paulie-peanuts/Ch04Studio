﻿

using Ch04Studio;

Console.WriteLine(System.DateTime.Now);
MenuItem item1 = new("burger", 9.55, "delic", "main course");
MenuItem item2 = new("fries", 4.55, "greasy", "appetizer");
Menu menu = new();
menu.AddItem(item1);
menu.AddItem(item2);

Console.WriteLine(item1.ToString());
Console.WriteLine(item1.IsNew());
Console.WriteLine(menu.ToString());
