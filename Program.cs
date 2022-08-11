namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float airOrdAmt = 700f;
            float seaOrdAmt = 400f;
            float railOrdAmt = 150f;
            Console.WriteLine("Welcome to Package Calc \n");
            Console.WriteLine("What is the weight of your package in Kg");


            try
            {
                string weight = Console.ReadLine();
                float fltWeight;
                bool isParsed = float.TryParse(weight, out fltWeight);
                if (isParsed)
                {
                    var train = new PackageByRail();
                    var ship = new PackageBySea();
                    var air = new PackageByAir();

                    Console.WriteLine(train.CalculateShippingCost(railOrdAmt, fltWeight));
                    Console.WriteLine(ship.CalculateShippingCost(seaOrdAmt, fltWeight));
                    Console.WriteLine(air.CalculateShippingCost(airOrdAmt, fltWeight));

                }
                else
                { 
                    Console.WriteLine("Invalid input");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error detected ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}