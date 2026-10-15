namespace homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = [25, 50, 100];

            //Console.WriteLine(Sum(arr));


            //int Sum(int[] x)
            //{
            //    int sum = 0;
            //    foreach (var item in x)
            //    {
            //        sum += item;
            //    }


            //    return sum;
            //}





            //PrintText("Hello", "Hi", "Bye");

            //void PrintText(string text1, string text2, string text3)
            //{
            //    Console.WriteLine($"{text1} {text2} {text3}");
            //}



            string[] names = ["John", "James"];


            string GetText(string[] inputNames)
            {

                return string.Join(" ", inputNames);
            }


            Console.WriteLine(GetText(names));


            
        }
    }
}
