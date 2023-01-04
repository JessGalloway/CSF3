using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1Library
{
    public class HourlyEmployee : Employee
    {

        //Fields
        private decimal _hourlyWage;
        private decimal _hoursWorked;
        private decimal _overtimeRate;

        //Props
        public decimal HourlyWage { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal OvertimeRate { get; set; }


        //Ctors

        public HourlyEmployee(string firstName, string lastName, DateTime dob, int employeeId, string position, DateTime dateOfHire, bool isDirectDeposit, decimal hourlyWage, decimal hoursWorked, decimal overtimeRate)
            : base(firstName, lastName, dob, employeeId, position, dateOfHire, isDirectDeposit)
        {
            HourlyWage = hourlyWage;
            HoursWorked = hoursWorked;
            OvertimeRate = overtimeRate;
        }

        //Methods

        public override decimal GetPayCheckAmount()
        {
            //Pay the employee
            //HoursWorked * hourlyWage = paycheckAmount

            //For this scenerio, We'll assume employees work up to 40 hours at their base rate. Anything over 40 is multiplied by the overtime rate

            decimal paycheck = 0;

            //Case # 1 : <= 40 hours

            if (HoursWorked <= 40)
            {
                paycheck = HoursWorked * HourlyWage;


            }
            else 
            {

                decimal otHours = HoursWorked - 40;
                paycheck = (HourlyWage * 40) + (otHours * HourlyWage * OvertimeRate);

            }

            return paycheck;
            

            

            //default behavior is to throw an excpetion wich fulfils the letter of the contract.
            //does not satisfy the spirit of the contract which is to return a decimal with tthe paycheck amount
            //throw new NotImplementedException();
        }

        public override string ToString() =>
            $"ID: {EmployeeId}\n{base.ToString()}\nPosition: {Position}\nHire Date: {DateOfHire}\nDirect Deposit? {(IsDirectDeposit ? "Yes" : "No")}\nHourly Wage: {HourlyWage}\nHours Worked: {HoursWorked}\nOvertime Rate: {OvertimeRate}";

    }
}
