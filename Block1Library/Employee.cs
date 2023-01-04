using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCPayroll;


namespace Block1Library
{
    //public inheritance only derived class called employee that extends the base Person class
    public abstract class Employee : Person, IPayable, IDirectDepositable//this is to show it is possible to implement more than one 
                                                                         //interface becasue of inheritance in the interface, we could simply implement IDirectDeposible on the line above 
                                                                         //in production code you would just remove IPayable , here we leave it to show that it is possible to implement more than one interface
                                                                         //made abstract so that it cannot be instantiated
    {
        //Fields
        //no fields - using auto props instead



        //Props
        //auto props
        public int EmployeeId { get; set; }

        public string Position { get; set; }

        public DateTime DateOfHire { get; set; }

        public bool IsDirectDeposit { get; set; }

        //Ctors

        public Employee(string firstName, string lastName, DateTime dob, int employeeId, string position, DateTime dateOfHire, bool isDirectDeposit)
            : base(firstName, lastName, dob) //the base is sending this info back to the base class
            //names can be unique but order has to be the same 
        {
            EmployeeId = employeeId;
            Position = position;
            DateOfHire = dateOfHire;
            IsDirectDeposit = isDirectDeposit;

        }

        //Methods


        //Added GetBankingInfo AFTER implementing IDirectDepositable

        public string GetBankingInfo() 
        {


            /*
             Banking infor can include (but not limited to):
                _Account #
            _Routing #
            _Bank Name
            _Bank Address
            _Bank Phone
            - Pin 
            
            
            our example will hardcode this info and it will be the same for ever employee. 
            in a production environment, these would need to preperties for you Employees so they can have dynamic data
             */

            return "Bank of America 002039948 399283299"; 

            
        }

        //Added the following 2 methods for implementing ipayable 

        public string GetNameForPaycheck() 
        {
            return $"{FirstName} {LastName}";
         
        }


        //WE do not appropriate info to generate or calc a paycheck here.
        //By declaring the method as abstract we can pass the responsibility to the derived classes to implement the behavior 
        public abstract decimal GetPayCheckAmount();




        public override string ToString() =>
            $"ID: {EmployeeId}\n{base.ToString()}\nPosition: {Position}\nHire Date: {DateOfHire}\nDirect Deposit? {(IsDirectDeposit ? "Yes" : "No")}";
        // base.ToString() calls back to the parents version of ToString
        //if IsDirectDeposit is true, then "Yes" is returned, otherwise "No" is returned

    }
}
