using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Block1Library
{
    public class SalariedEmployee : Employee
    {
        //Fields
        private decimal _yearlySalary;
        private string _payFrequency;

        //Props

        public decimal YearlySalary { get; set; }
        public string PayFrequency { get; set; }


        //Ctors

        public SalariedEmployee(string firstName, string lastName, DateTime dob, int employeeId, string position, DateTime dateOfHire, bool isDirectDeposit, decimal yearlySalary, string payFrequency)
            : base(firstName, lastName, dob, employeeId, position, dateOfHire, isDirectDeposit)
        {
            YearlySalary = yearlySalary;
            PayFrequency = payFrequency;
        }


        //Methods
        //

        public override decimal GetPayCheckAmount()
        {
            //Pay period/frequency 
            //Weekly - 52, Bi-Weekly - 26, Bi-monthly / semi- monthly = 24, Monthly = 12 paychecks 

            //ranges in switch statements 

            if (PayFrequency.ToLower() == "weekly")
            {

                return YearlySalary / 52;

            }
            else if (PayFrequency.ToLower() == "bi-weekly")
            {
                return YearlySalary / 26;

            }
            else if (PayFrequency.ToLower() == "bi-monthly" || PayFrequency.ToLower() == "semi-monthly")
            {

                return YearlySalary / 24;

            }
            else if (PayFrequency.ToLower() == "monthly")
            {

                return YearlySalary / 12;

            }
            else 
            {
                //if for whatever reason we didnt get a match on frequency return 0
                return 0;
            
            }


        }



        public override string ToString()  => $"ID: {EmployeeId}\n{base.ToString()}\nPosition: {Position}\nHire Date: {DateOfHire}\nDirect Deposit? {(IsDirectDeposit ? "Yes" : "No")} Yearly Salary: {YearlySalary}\nPay Frequency: {PayFrequency}";

    }
}

