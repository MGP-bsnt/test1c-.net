namespace sqlite_con_menu
{

		public class Menu //Console menu options
		{



			public void GetUserInput()
			{

				UpdateInventory update = new UpdateInventory();
				GetAllRecordsInventory getRecords = new GetAllRecordsInventory();
				InsertProduct insert = new InsertProduct(); 	

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
							getRecords.GetAllRecords();
							break;

						case "2":
						//Insert(); --> separar clase antes de pasar
							insert.Insert();
							getRecords.GetAllRecords();
							break;

						case "3":
							
							update.Update();
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

