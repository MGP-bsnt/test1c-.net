using Data.Access;
using Data.Model;

namespace InventoryControl
{
    public class Print
    {
        InventoryAccess access = new InventoryAccess();
        public void ConsolePrint()
        {
            List<Inventory> records;
            records = access.GetAllRecords();
            Console.WriteLine("\n //  Id  //   Name   //  Expiry Date  //  Type  //  Price  //  Weight  //  Date Added // \n");
            foreach (var iv in from inv in records
                     select new { inv.Id, inv.Name, inv.ExpiryDate, inv.Type, inv.Price, inv.Weight, inv.DateAdd })
            {
                Console.WriteLine($"{iv.Id}  -  {iv.Name}  -  {iv.ExpiryDate}  -  {iv.Type}  -  " +
                    $"{iv.Price}  -  {iv.Weight}  -  {iv.DateAdd}");
            }
        }
    }
}
