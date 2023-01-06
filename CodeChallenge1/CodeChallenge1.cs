namespace CodeChallenge1
{
    internal class CodeChallenge1

    {
        private static void Main(string[] args)
        {
            /*
              a. If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3,5,6, and 9. The sum of these multiples is 23.

            b. Find the sum of all multiples of 3 or 5 below 1000 and print it out to the console.

            C. if a multiple of 3 print fizz 
            d if multifple of 5 print buzz
            e. if both print fize buzz


             */

            var numbBellow1000 = Enumerable.Range(1, 1001);

            foreach (var item in numbBellow1000)
            {
                if (item % 3 == 0 )
                {
                    Console.WriteLine(item + "fizz");
                }
                else if (item % )
            }


        }
    }
}