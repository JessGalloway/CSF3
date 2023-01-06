internal class Challenge1_Multiple3sand5s
{
    private static void Main(string[] args)
    {
        /*
              a. If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3,5,6, and 9. The sum of these multiples is 23.

                b. Find the sum of all multiples of 3 or 5 below 1000 and print it out to the console.
         
         
         */



        var below1000 = Enumerable.Range(1, 1001).ToArray();
        foreach (int i in below1000)
        {

            if (i % 3 == 0 || i % 5 == 0)
            {
                Console.WriteLine(i);
            }
           
                                  
        }

        

    }
}