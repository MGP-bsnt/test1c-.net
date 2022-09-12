namespace Data.Model
{
    public class Inventory
    {
        public int Id { get; set; }
        public string ? Name { get; set; }
        public string ? ExpiryDate { get; set; }
        public string ? Type { get; set; }
        public string ? Price { get; set; }
        public string ? Weight { get; set; }
        public string ? DateAdd { get; set; }
        public int InvStatus { get; set; }



    }

    class ObtainData
    {
        public static void Obtaininventory()
        {
            List<Inventory> InventoryDB = new List<Inventory>()
        {
            new Inventory { Name="Ann", Type=""},
        };
        }
    }
    
}

