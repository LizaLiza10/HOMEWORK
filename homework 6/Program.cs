using System.Reflection.Metadata.Ecma335;

namespace homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 5, 10, 15, 20 };

            //int getarray(int[] arr)
            //{
            //    int sum = 0;

            //    foreach (int num in arr)
            //    {
            //        sum += num;
            //    }

            //    return sum; 
            //}
            //int result = getarray(numbers);

            //Console.WriteLine("The sum is: " + result);




            //void FullSentence(string text1, string text2, string text3)
            //{
            //    string combinedText = text1 + " " + text2 + " " + text3;
            //    Console.WriteLine(combinedText);
            //}

            //FullSentence("how", "are", "you");


            string CombineArray(string[] words)
            {
                if (words.Length == 0) return "";

                string combinedText = words[0];

                for (int i = 1; i < words.Length; i++)
                {
                    combinedText += " " + words[i];
                }

                return combinedText;
            }

            string[] myArray = { "gamarjoba", "me", "var", "liza", "pkho" };
            string result = CombineArray(myArray);

            Console.WriteLine(result);


        }
        
    }
}
