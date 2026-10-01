namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string adminuser = "admin";
            //string adminpass = "1234";

            //string userName = Console.ReadLine();
            //string userPass = Console.ReadLine();

            //if (userName == "admin" && userPass == "1234") {
            //    Console.WriteLine("welcome");

            //}
            //else
            //{
            //    Console.WriteLine("access denied");
            //}



            //int age = int.Parse(Console.ReadLine());
            //if (age >= 0 && age<=12)
            //{
            //    Console.WriteLine("you are a child");
            //}
            //else if (age >= 13 && age <= 19 ) {
            //    Console.WriteLine("you are a teenager");
            //}
            //else if (age>= 20 && age <= 64)
            //{
            //    Console.WriteLine("you are an adult ");
            //}
            //else if (age>= 65)
            //{
            //    Console.WriteLine("you are a senior citizen");
            //}
            //else
            //{
            //    Console.WriteLine("invalid age ");
            //}

            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter operator: ");
            char op = char.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            if (op == '+')
            {
                Console.WriteLine(num1 + num2);

            }
            else if (op == '-')
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == '*')
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == '/')
            {
                if (num2 != 0)
                {
                    Console.WriteLine(num1 / num2);
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
            }
            else
            {
                Console.WriteLine("Invalid operator.");
            }

        }
    }
}
