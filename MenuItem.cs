using System;

namespace assignment8
{
	public class MenuItem
	{
		String name;
		String description;
		bool vegetarian;
		double price;
		public MenuItem(String name,
		String description,
		bool vegetarian,
		double price)
		{
			this.name = name;
			this.description = description;
			this.vegetarian = vegetarian;
			this.price = price;
		}

		public String getName()
		{
			return name;
		}

		public String getDescription()
		{
			return description;
		}

		public double getPrice()
		{
			return price;
		}

		public bool isVegetarian()
		{
			return vegetarian;
		}
	}
}
