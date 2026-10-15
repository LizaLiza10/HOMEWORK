namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] transactions = { 120, -50, 300, -100, 80, -200, 500, -30, 150, -400 };
            int countPositive = 0;
            int countNegative = 0;
            int sumPositive = 0;
            int sumNegative = 0;


            foreach (var item in transactions)
            {

                if (item > 0)
                {
                    Console.WriteLine("Dadebiti");
                    countPositive++;
                    sumPositive += item;
                }
                else if (item == 0)
                {
                    Console.WriteLine("arsheileba");
                }
                else
                {
                    Console.WriteLine("uaryopiti");
                    countNegative++;
                    sumNegative += -item;
                }
            }

            Console.WriteLine(sumPositive);
            Console.WriteLine(sumNegative);
            Console.WriteLine($"balance = {sumPositive - sumNegative}");
        }
    }
}
