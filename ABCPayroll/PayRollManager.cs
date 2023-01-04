using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPayroll
{
    public static class PayRollManager
    {
        //made this static so we do not have create an instance prior to calling methods
        public static void ProcessPaycheck(IPayable target) ///static classes must have static methods
        {

            //To process a paycheck, we must ensrue that the object passed to thi smethod implements the appropriate interfaec. 
            //we know the employee does this but to get any object that implements the interface we can use an instance of IPayable as the parameter (IPayable target)


            //Simulate inssuance of a paychet by outputting to console

            Console.WriteLine($"A paper Check has been issued to {target.GetNameForPaycheck()}\nThe ammount paid was  {target.GetPayCheckAmount():c}");
            
    

        }
        //issue direct deposit

        public static void DoDirectDeposit(IDirectDepositable target) 
        {

            //Simulate a EFI by wrting to the console

            Console.WriteLine($"An EFT was initialized for {target.GetNameForPaycheck()}\nThe amount paid was {target.GetPayCheckAmount():c}\nThe funds were tranferred to {target.GetBankingInfo()}");

        }

    }
}
