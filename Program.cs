namespace assignment8
{
    class PancakeDinerHouse
    {
        static void Main(string[] args)
        {
			PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
			DinerMenu dinerMenu = new DinerMenu();
			Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);
			waitress.printMenu();
		}
    }
}
