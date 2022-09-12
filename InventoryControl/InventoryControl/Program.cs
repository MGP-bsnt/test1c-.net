
using Data.Access;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;

namespace sqlite_con_menu
{
    partial class Program
	{
		static void Main(string[] args)
		{
			var menu = new Menu();

            InventoryAccess.CreateTableInventory();

			menu.GetUserInput();
		}
    }
}