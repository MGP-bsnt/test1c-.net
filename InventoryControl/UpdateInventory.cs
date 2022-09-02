namespace sqlite_con_menu
{
 
		class UpdateInventory //Changes the column InvStatus from 1 (active) to 0 (Inactive)
		{
			public void Update()
			{


				try
				{
					using (System.Data.SQLite.SQLiteConnection connection = new System.Data.SQLite.SQLiteConnection("data source = InventoryDB.db3"))
					{
						using (System.Data.SQLite.SQLiteCommand tableCmd = new System.Data.SQLite.SQLiteCommand(connection))
						{
							connection.Open();

							// Get name to update, also checks if it exists and is not already out of inventory.

							Console.WriteLine("\nInsert the Name of the product to be taken out of inventory:\n");
							var NameUpdate = Console.ReadLine();
							var i = 0;

							tableCmd.CommandText = $"SELECT * FROM Inventory WHERE Name = '{NameUpdate}' AND InvStatus = 1";

							using (System.Data.SQLite.SQLiteDataReader reader = tableCmd.ExecuteReader())
							{
								while (reader.Read())
								{
									i++;
								}
							}

							if (i == 0)
							{
								Console.WriteLine($"\nRow with the Name {NameUpdate} do not exist.\n");
							}
							else
							{
								// Sets column "InvStatus" to 0, to get the producto out of inventory.
								int setInvOut = 0;

								tableCmd.CommandText = $"UPDATE Inventory SET InvStatus = '{setInvOut}' WHERE Name = '{NameUpdate}' AND InvStatus = 1";

								tableCmd.ExecuteNonQuery();

								Console.WriteLine($"\nRow with the Name {NameUpdate} is now out of the inventory.\n");

							}
							connection.Close();
						}
					}
				}
				catch (Exception)
				{
					Console.WriteLine("An error has occured.");
					throw;
				}
			}
		}
}