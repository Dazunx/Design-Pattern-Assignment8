using System;

namespace assignment8
{
	public class PancakeHouseMenu
	{
		internal const int MAX_ITEMS = 6;
		int numberOfItems = 0;
		MenuItem[] menuItems;


		public PancakeHouseMenu()
		{
			menuItems = new MenuItem[MAX_ITEMS];

			addItem("K&B's Pancake Breakfast",
				"Pancakes with scrambled eggs, and toast",
				true,
				2.99);

			addItem("Regular Pancake Breakfast",
				"Pancakes with fried eggs, sausage",
				false,
				2.99);

			addItem("Blueberry Pancakes",
				"Pancakes made with fresh blueberries, and blueberry syrup",
				true,
				3.49);

			addItem("Waffles",
				"Waffles, with your choice of blueberries or strawberries",
				true,
				3.59);
		}
		public void addItem(String name, String description, bool vegetarian, double price)
		{
			MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
			if (numberOfItems >= MAX_ITEMS)
			{
				Console.Error.WriteLine("Sorry, menu is full!Can’t add item to menu");
			}
			else
			{
				menuItems[numberOfItems] = menuItem;
				numberOfItems = numberOfItems + 1;
			}
		}
		public Iterator createIterator()
		{
			return new PancakeHouseMenuIterator(menuItems);
		}
	}
}
