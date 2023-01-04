using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1Library
{
    public sealed class Manager : SalariedEmployee //marked as sealed to note the end of our inheritance chain
    {
        //Fields
        private Decimal _yearlyBonus;

        //Props
        public Decimal YearlyBonus { get; set; }

        //Ctors
        public Manager(string firstName, string lastName, DateTime dob, int employeeId, string position, DateTime dateOfHire, bool isDirectDeposit, decimal yearlySalary, string payFrequency, decimal yearlyBonus)
            : base(firstName, lastName, dob, employeeId, position, dateOfHire, isDirectDeposit, yearlySalary, payFrequency)
        {
            YearlyBonus = yearlyBonus;
        }

        //Methods

        //By default Manager inherits functionality of GetPayCheckAmount() from salaried employee however manager should also get a bonuse in addition to the salary bonus
        //WE need to override the deifinition for GetPayCheckAmount() in the SalariedEmployee class

        public override decimal GetPayCheckAmount()
        {
            //BOnus can be distributed multiple ways - figure out how the company does this first
            //We will assum the bonus is distributed evenly throughout the year with each paycheck for the Manager

            if (PayFrequency.ToLower() == "weekly")
            {

                return (YearlySalary / 52) +(YearlyBonus / 52);

            }
            else if (PayFrequency.ToLower() == "bi-weekly")
            {
                return (YearlySalary / 26) + (YearlyBonus / 26);

            }
            else if (PayFrequency.ToLower() == "bi-monthly" || PayFrequency.ToLower() == "semi-monthly")
            {

                return (YearlySalary / 24) + (YearlyBonus / 24);

            }
            else if (PayFrequency.ToLower() == "monthly")
            {

                return (YearlySalary / 12) + (YearlyBonus / 12);

            }
            else
            {
                //if for whatever reason we didnt get a match on frequency return 0
                return 0;

            }

           


        }



        public override string ToString() =>
            $"ID: {EmployeeId}\n{base.ToString()}\nPosition: {Position}\nHire Date: {DateOfHire}\nDirect Deposit? {(IsDirectDeposit ? "Yes" : "No")} Yearly Salary: {YearlySalary}\nPay Frequency: {PayFrequency}\nYearly Bonus: {YearlyBonus}";
    }

    //pulblic class CEO : Manager {} //this would be an error because Manager is sealed and cannot be inherited




  

}
