using System;

namespace assignment8
{
	public interface Iterator
	{
		bool hasNext();
		Object next();
	}

	public class PancakeHouseMenuIterator : Iterator
	{
		MenuItem[] items;
		int position = 0;
		public PancakeHouseMenuIterator(MenuItem[] items)
		{
			this.items = items;
		}
		public Object next()
		{
			MenuItem menuItem = items[position];
			position = position + 1;
			return menuItem;
		}
		public bool hasNext()
		{
			if (position >= items.Length || items[position] == null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}

	public class DinerMenuIterator : Iterator
	{
		MenuItem[] items;
		int position = 0;
		public DinerMenuIterator(MenuItem[] items)
		{
			this.items = items;
		}
		public Object next()
		{
			MenuItem menuItem = items[position];
			position = position + 1;
			return menuItem;
		}
		public bool hasNext()
		{
			if (position >= items.Length || items[position] == null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}