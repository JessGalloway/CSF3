using ABCPayroll;
using Block1Library;

//Person p = new Person("Johnny", "Five", new DateTime(1989, 10, 20));

//Console.WriteLine(p);

//HourlyEmployee e = new HourlyEmployee("Johnny", "AppleSeed", new DateTime(1981, 1, 2), 13, "Developer", new DateTime(2016, 7, 8), true);

//Console.WriteLine(e);


HourlyEmployee e = new HourlyEmployee("john" , "gates", new DateTime(1981, 1, 2), 13, "Developer", new DateTime(2016, 7, 8), false, 10, 40, 1.5m);
Console.WriteLine(e);
SalariedEmployee sE = new SalariedEmployee("john", "gates", new DateTime(1981, 1, 2), 13, "Developer", new DateTime(2016, 7, 8), true, 100000, "bi-weekly");
Console.WriteLine(sE);
Manager m = new Manager("john", "gates", new DateTime(1981, 1, 2), 13, "Developer", new DateTime(2016, 7, 8), true, 100000, "bi-weekly", 100000);
Console.WriteLine(m);

/*
 * LAB:
 * 1) Create the class HourlyEmployee that inherits from Employee
 *          - HourlyWage (decimal)
 *          - HoursWorked (decimal)
 *          - OvertimeRate (decimal)
 *          - Create a fully-qualified constructor
 *          - Create a nicely formatted ToString()
 *          
 * 2) Create the class SalariedEmployee that inherits from Employee
 *          - YearlySalary (decimal)
 *          - PayFrequency (string)
 *          - Create a fully-qualified ctor
 *          - Create a nicely formatted ToString()
 *          
 * 3) Create the class Manager that inherits from SalariedEmployee
 *          - YearlyBonus (decimal)
 *          - Create a fully-qualified ctor
 *          - Create a nicely formatted ToString()
 * */



Console.WriteLine("Simulate paying employees....\n\n");


//commented code below after adding the "static" keyword to PayRollManager class
//PayRollManager pm = new PayRollManager();

//pm.ProcessPaycheck(e);

//pm.ProcessPaycheck(sE);

//pm.ProcessPaycheck(m);



//PayRollManager.ProcessPaycheck(e);
//PayRollManager.ProcessPaycheck(sE);
//PayRollManager.ProcessPaycheck(m);



List<IPayable> employees = new List<IPayable>() { e, sE, m };


foreach (Employee emp in employees)
{
    if (emp.IsDirectDeposit)
    {

        PayRollManager.DoDirectDeposit(emp);
        
    }
    else 
    {
        
        PayRollManager.ProcessPaycheck(emp);

    }
}

















