using Block1Library;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ 
{


    class Student 
    {

        public string Name { get; set; }
        public string Gradelevel { get; set; }

        public DateTime StartDate { get; set; }


    }








    
    class IntroToLinq 
    {

        #region LinqNotes
        /*****************LINQ Information************************
        * LINQ stands for Language INtegrated Query
        * It is a uniqform query syntax in C# that allows us to retrieve and search multiple different data sources. 
        * 
        * Linq was part of a LARGE enhancement to .NET and C# in version 3.5
        * Other portions of that enhancement include (but are not limited to):
        * -Inferred Data types: use of the var keyword and the compiler can figure
        * out what data type the variable should be based on its context.
        * 
        * -Object Initializers: Easier shorthand way of setting the state of 
        * a new object. (Assigning values to each of the properties and creating
        * the object) - work and look like Collection Initialization syntax
        * 
        * -Prop[tab][tab] - Automatic Properties: Allow us to easily create 
        * properties in our classes without having to declare a private field
        * and refactor to a public property (as long as there are no biz rules)
        * 
        * -Anonymous Types: Creating new types of objects on the fly without needing
        * to create a class for them. When you see "new { //code here }" that is the
        * creation of an anonymous object. 
        * 
        * -Extension Methods: Adding new behavior to existing classes without having
        * to put that method in the original class file.
        * 
        * -Lambda Expressions: Allow us to pass parameters and an expression for
        * that parameter into the extension methods in .NET (or our own)
        * 
        * Two Main Syntaxes 
        * Method/Lambda Syntax: This uses extension methods with lambda expressions (=> read evaluates to) 
        * Keyword/Query Syntax: This is written similar to SQL (language used in backend for querying databases)
        */
        #endregion

        static void Main(string[] args)
        {

            #region Object initialization syntax

            //For this syntax to work , your class must have a public no arg ctor

            Student s = new Student()
            {

                Name = "Bob Boberts",
                Gradelevel = "Sophmore",
                StartDate = new DateTime(2022, 1, 1)

            };

            Console.WriteLine(s);//Namespace.ClassName[Linq.Student]

            Console.WriteLine($"Name: {s.Name}\nGrade: {s.Gradelevel}\nStart Date: {s.Gradelevel}");


            //inferred typing 

            var s1 = s;

            //inferred typing mixed with object initialization

            var s2 = new Student() { Name = "John Bon", Gradelevel = "Freshman", StartDate = new DateTime(2021, 10, 2) };


            //practical application 
            //a temporary collection of objects to manipulate and then discard
            //the objects here will ONLY exist within the collection
            //weapons
            var students = new List<Student>()
            {
                new Student(){ },/*Prop assigment here*/            
                new Student(){ },/*Prop assigment here*/
                new Student(){ },/*Prop assigment here*/
                new Student(){ },/*Prop assigment here*/

            };



            students.Clear(); //remove all objects from the collection (collection still exists)

            //THIS WILL WORK FOR LOOTING IN DUNGEON

            //Anonymous typing 
            //Creates a new kind of object (new class without creating a class!)

            var pet = new { Age = 10, Name = "Meatloaf", Breed = "Husky" };

            Console.WriteLine(pet);

            //formatted output
            Console.WriteLine($"Name: {pet.Name}\nAge: {pet.Age}\nBreed: {pet.Breed}");

            Console.Clear();









            #endregion



            #region Hourly Employee Objects


            //creat 5 hoursly employee objects

            HourlyEmployee he1 = new HourlyEmployee("john", "gates", new DateTime(1981, 1, 2), 132, "Developer", new DateTime(1916, 5, 28), false, 60, 40, 2.5m); ;

            HourlyEmployee he2 = new HourlyEmployee("Karen", "gates", new DateTime(1991, 7, 2), 123, "Catcher", new DateTime(1981, 6, 8), true, 54, 40, 2.5m); ;

            HourlyEmployee he3 = new HourlyEmployee("Ace", "gerry", new DateTime(1901, 3, 2), 213, "Pitcher", new DateTime(2016, 10, 8), false, 18, 40, 4.5m);

            HourlyEmployee he4 = new HourlyEmployee("Sara", "ates", new DateTime(1989, 1, 12), 2213, "Enterloper", new DateTime(2015, 7, 18), true, 34, 40, 1m);

            HourlyEmployee he5 = new HourlyEmployee("jay", "lates", new DateTime(3000, 12, 2), 21113, "loped", new DateTime(2013, 10, 13), false, 20, 40, 1.5m);
            #endregion

            var hourlyEmployees = new List<HourlyEmployee>() { he1, he3, he5, he4, he2 };


            //Show employees that meet the following conditions: 
            //Hourly wage > 50 and born before 1985

            foreach (var emp in hourlyEmployees)
            {

                if (emp.HourlyWage > 50 && emp.DateOfBirth.Year < 1985)
                {
                    Console.WriteLine($"{emp}======\n\n");

                }

                //Show the same results as above, this time using LINQ Method Syntax

                var emps = hourlyEmployees.Where(emp1 => emp.HourlyWage > 50 && emp.DateOfBirth.Year > 1985);

                //syntax Breakdown
                //var [filteredcollection] = [collection to query].Where({on the fly var} that evaluates to (=>) otfvar.Prop == Condiiton)
                //collection.where(var => collect.prop == condition)

                foreach (var emp1 in emps)
                {
                    Console.WriteLine(emp + "\n------------");


                }

                var empsKw = from emp1 in hourlyEmployees
                             where emp1.HourlyWage > 50
                             && emp1.DateOfBirth.Year < 1985
                             select emp1;


                //var [filteredCollection] = from [otfVar] in [collection to query]
                //where[otVar].[prop] == [condition]
                //select[otfvar];

                foreach (var emp1 in empsKw)
                {
                    Console.WriteLine(emp1 + "\n==========");
                }

                // - Retrieve employees with the last name Gates

                //Method syntax 

                var empsSameLastName = hourlyEmployees.Where(x => x.LastName.ToLower() == "gates");

                foreach (var emp1 in empsSameLastName)
                {

                    Console.WriteLine(emp.FirstName + "" + emp.LastName + "\n------------\n");

                }


                var empSameLastNameKw = from emp1 in hourlyEmployees
                                        where emp.LastName.ToLower() == "gates"
                                        select emp;



            }



            Console.Clear();

            //sorting data
            //you can sort by ascending (default) or descending (requires a different method or keyword)

            var empsSortedByPay = hourlyEmployees.OrderByDescending(x => x.HourlyWage);

            foreach (var emp in empsSortedByPay)
            {

                Console.WriteLine(emp + "\n-----------");

            }


            //sorting w/ keywork syntax

            var empsSortedKW = from emp in hourlyEmployees
                               orderby emp.HourlyWage descending //<<<<<descending typed here will flip it from ascending to descending order
                               select emp;

            foreach (var emp in empsSortedKW)
            {
                Console.WriteLine(emp + "\n-----------\n");
            }




            // Mini Lab
            // 1. Display employees that were hired before 2020

            //2. display employees whos first names start with b

            //3. display empoloyees who do not use direct deposit and make more than 30 an hour

            Console.Clear();

            var empBefore2020 = hourlyEmployees.OrderBy(x => x.DateOfHire);

            foreach (var emp in empBefore2020)
            {

                if (emp.DateOfHire.Year < 2020)
                {

                    Console.WriteLine(emp + "\n----------\n");

                }



            }


            var empFirstName = hourlyEmployees.OrderBy(x => x.FirstName.StartsWith("B"));

            foreach (var emp in empFirstName) 
            {


                Console.WriteLine(emp + "\n--------\n");
            }


            var empEmp = hourlyEmployees.OrderBy(x => x.IsDirectDeposit);

            foreach (var emp in empEmp)
            {
                if (!emp.IsDirectDeposit && emp.HourlyWage > 30)
                {
                    Console.WriteLine(emp);
                }
            }
            

        }

    }

}
