using Data.Access;
using Data.Model;
using InventoryControl;

namespace sqlite_con_menu
{
	public class Menu //Console menu options
	{
		Print print = new Print();
		public void GetUserInput()
		{
			InventoryAccess access = new InventoryAccess();

			bool closeApp = false;
			while (closeApp == false)
			{
				Console.WriteLine("\n -- Main Menu  --");
				Console.WriteLine("\n Select an option:");
				Console.WriteLine("\n 1 - View all records from Inventory.");
				Console.WriteLine("\n 2 - Insert New Record to Inventory.");
				Console.WriteLine("\n 3 - Take product out of Inventory.\n");
				Console.WriteLine("\n 4 - Exit.\n");

				var commandInput = Console.ReadLine();

				switch (commandInput)
				{
					case "1":
						//records = access.GetAllRecords(); --> Lo he pasado a la clase Print para reaprovechar y usarlo en
						//varios sitios.
						print.ConsolePrint();
						break;

					case "2":
						access.Insert();
                        print.ConsolePrint();
                        break;

					case "3":
						access.Update();
						break;

					case "4":
						closeApp = true;
						break;
					default:
						Console.WriteLine("\nInvalid Command.");
						break;
				}
			}
		}
	}
}

