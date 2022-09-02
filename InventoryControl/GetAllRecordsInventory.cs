namespace sqlite_con_menu
{
	class GetAllRecordsInventory //Gets all inventory records that are active
		{
			public void GetAllRecords()
			{

				try
				{
					using (System.Data.SQLite.SQLiteConnection connection = new System.Data.SQLite.SQLiteConnection("data source = InventoryDB.db3"))
					{
						using (System.Data.SQLite.SQLiteCommand tableCmd = new System.Data.SQLite.SQLiteCommand(connection))
						{
							connection.Open();
							tableCmd.CommandText = $"SELECT Id, Name, ExpiryDate, Type, Price, Weight, DateAdd FROM Inventory WHERE InvStatus = 1";

							Console.WriteLine("\n //  Id  //   Name   //  Expiry Date  //  Type  //  Price  //  Weight  //  Date Added // \n");
							using (System.Data.SQLite.SQLiteDataReader reader = tableCmd.ExecuteReader())
							{
								while (reader.Read())
								{
									Console.WriteLine("-  " + reader["Id"] + "   :   " + reader["Name"] + "   :   " + reader["ExpiryDate"] + "   :   " + reader["Type"] +
										"   :   " + reader["Price"] + "   :   " + reader["Weight"] + "   :   " + reader["DateAdd"] + "\n");
								}
							}
							connection.Close();
						}
					}
				}
				catch (Exception)
				{
					Console.WriteLine("An error occurred while reading the Database.");
					throw;
				}
				
			}
		}

	
}

