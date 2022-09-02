
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;

namespace sqlite_con_menu
{
    partial class Program

	{
		static void Main(string[] args)
		{

			var tableDB = new CreateTable();
			var menu = new Menu();

			tableDB.CreateTableInventory();
			menu.GetUserInput();


		}
    }
		

}