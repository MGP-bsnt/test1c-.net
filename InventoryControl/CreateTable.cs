namespace sqlite_con_menu
{

		class CreateTable
		{
			public void CreateTableInventory()
			{
				try
				{
					if (!File.Exists(@"InventoryDB.db3"))
					{
						System.Data.SQLite.SQLiteConnection.CreateFile("InventoryDB.db3");
						using (System.Data.SQLite.SQLiteConnection connection = new System.Data.SQLite.SQLiteConnection("data source = InventoryDB.db3"))
						{
							using (System.Data.SQLite.SQLiteCommand tableCmd = new System.Data.SQLite.SQLiteCommand(connection))
							{
								connection.Open();

								tableCmd.CommandText =
									@"CREATE TABLE IF NOT EXISTS Inventory (
								Id	INTEGER,
								Name	TEXT NOT NULL,
								ExpiryDate	TEXT NOT NULL,
								Type	TEXT,
								Price	REAL,
								Weight	REAL,
								DateAdd	TEXT NOT NULL,
								InvStatus	INTEGER NOT NULL,
								PRIMARY KEY(Id AUTOINCREMENT)
								);";

								tableCmd.ExecuteNonQuery();

								connection.Close();
							}


						}

					}
				}
				catch (Exception)
				{
				Console.WriteLine("Error occurred during creation of Database");
				throw;
				}
				
			
			}
		}
}
