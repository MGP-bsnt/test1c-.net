namespace sqlite_con_menu
{
 
    public class InsertProduct
        {
        public void Insert()
        {
            string NameAdd = GetNameInput();
            string expiryDateAdd = GetExpiryDateInput();
            string typeAdd = GetTypeInput();
            double priceAdd = GetPriceInput();
            double weightAdd = GetWeightInput();



            var dateAdd = DateTime.Now.ToString("dd/MM/yyyy");
            int invStatus = 1;





            try
            {
                using (System.Data.SQLite.SQLiteConnection connection = new System.Data.SQLite.SQLiteConnection("data source = InventoryDB.db3"))
                {
                    using (System.Data.SQLite.SQLiteCommand tableCmd = new System.Data.SQLite.SQLiteCommand(connection))
                    {
                        connection.Open();
                        tableCmd.CommandText = $"INSERT INTO Inventory (Name, ExpiryDate, Type, Price, Weight, DateAdd, InvStatus ) VALUES ('{NameAdd}','{expiryDateAdd}','{typeAdd}','{priceAdd}','{weightAdd}','{dateAdd}','{invStatus}')";

                        tableCmd.ExecuteNonQuery();

                        connection.Close();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured, during conexion to THE Database.");
                throw;
            }
        }

        internal static string GetNameInput()
        {

            string input = "";

            bool isOk = false;

            while (isOk == false)
            {

                Console.WriteLine("\nEnter product Name:\n");
                input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"\n{input} added");
                    isOk = true;
                    return input;
                }
                else
                {
                    Console.WriteLine("\nPlease enter a Name");

                }
            }
            return input;
        }

        internal static string GetExpiryDateInput()
        {

            int outputDay;
            int outputMonth;
            int outputYear;
            
            var outputDayString = "";
            var outputMonthString = "";
            var outputYearString = "";

            string outputYearStringfull;




            Console.WriteLine("\nEntering the Expiring Date of the product");

            while (true)
            {
                Console.WriteLine("\nEnter day:");
                var inputDay = Console.ReadLine();
                if( Int32.TryParse(inputDay, out outputDay))
                {
                    outputDayString = outputDay.ToString();
                    if (outputDayString.Length == 2 || outputDayString.Length == 1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter 2 numbers maximum");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Enter the day number");
                }
            }

            
            while (true)
            {
                Console.WriteLine("\nEnter Month:");
                var inputMonth = Console.ReadLine();
                if (Int32.TryParse(inputMonth, out outputMonth))
                {
                    if(outputMonth >= 1 && outputMonth <= 12)
                    {
                        outputMonthString = outputMonth.ToString();
                        if (outputMonthString.Length == 2 || outputMonthString.Length == 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter 2 numbers maximum");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a number between 1 and 12");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Enter the Month number");
                }
            }

            while (true)
            {

                Console.WriteLine("\nEnter Year:");
                var inputYear = Console.ReadLine();
                if (Int32.TryParse(inputYear, out outputYear))
                {
                    outputYearString = outputYear.ToString();

                    if (outputYearString.Length == 2)
                    {
                        outputYearStringfull = $"20{outputYearString}";
                        break;
                    }
                    else if(outputYearString.Length == 4)
                    {
                        outputYearStringfull = outputYearString;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid Year");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid Year");
                }
            }



            string totalDate = $"{outputDayString.PadLeft(2, '0')}/{outputMonthString.PadLeft(2, '0')}/{outputYearStringfull}";
            return totalDate;
        }

        internal static string GetTypeInput()
        {
            Console.WriteLine("\nEnter product Type:");
            string input = Console.ReadLine();

            return input;
        }

        internal static double GetPriceInput()
        {
            Console.WriteLine("\nEnter Net Price of the Product:");

            var input = Console.ReadLine();
            double finalInput;

            if (!double.TryParse(input, out finalInput))
            {
                Console.WriteLine("\nPlease enter a Number.");
            }

            return finalInput;
        }


        internal static double GetWeightInput()
        {
            Console.WriteLine("\nEnter the weight of the product in Kilos:");

            var input = Console.ReadLine();
            double finalInput;

            if (!double.TryParse(input, out finalInput))
            {
                Console.WriteLine("\nPlease enter a Number.");
            }

            return finalInput;
        }

    }
}
        

