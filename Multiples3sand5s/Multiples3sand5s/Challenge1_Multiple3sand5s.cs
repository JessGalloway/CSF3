internal class Challenge1_Multiple3sand5s
{
    private static void Main(string[] args)
    {
        /*
              a. If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3,5,6, and 9. The sum of these multiples is 23.

                b. Find the sum of all multiples of 3 or 5 below 1000 and print it out to the console.
         
         
         */


        //int[] below1000 = new int[1000];

        //for (int i = 0; i < below1000.Length; i++)
        //{
        //    below1000[i] = i;


        //}

        var below1000 = Enumerable.Range(1, 1001).ToArray();
        foreach (int i in below1000)
        {

            if (1000 % i == 0 && i > 0) 
            {
                
                int naturalNumb = i;
                Console.WriteLine($" A natural numbers that devides evenly into 1000 and is below 1000 is {naturalNumb}");
                
                


            }
                                  
        }

        

    }
}