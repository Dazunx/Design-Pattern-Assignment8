using System;

namespace assignment8
{
	public class Waitress
	{
		PancakeHouseMenu pancakeHouseMenu;
		DinerMenu dinerMenu;
		public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
		{
			this.pancakeHouseMenu = pancakeHouseMenu;
			this.dinerMenu = dinerMenu;
		}
		public void printMenu()
		{
			Iterator pancakeIterator = pancakeHouseMenu.createIterator();
			Iterator dinerIterator = dinerMenu.createIterator();
			Console.WriteLine("MENU\n----\nBREAKFAST");
			printMenu(pancakeIterator);
			Console.WriteLine("\nLUNCH");
			printMenu(dinerIterator);
		}
		private void printMenu(Iterator iterator)
		{
			while (iterator.hasNext())
			{
				MenuItem menuItem = (MenuItem)iterator.next();
				Console.Write(menuItem.getName() + ", ");
				Console.Write(menuItem.getPrice() + " -- ");
				Console.WriteLine(menuItem.getDescription());
			}
		}
	}

}
