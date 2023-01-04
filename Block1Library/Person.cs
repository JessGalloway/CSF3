using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1Library
{
    public abstract class Person //Marked as abstract so this cannot be instantiated, and exists solely to pass class members to derived classes
    {
        //Fields
        // convention _camelCase
        // convention private
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;


        //Properties
        //conventions: public and PascalCase
        //
        public string FirstName 
        {
            get { return _firstName; }
            set
              
            {
                //when a person is instantiated, we will check to see if there is a value present for fistName
                //if so use the value given 
                //otherwise assign a value of "name of not given"
                
                if (value.Count() > 1)
                {
                    _firstName = value;


                }
                else
                {

                    _firstName = "Name not given";
                }

            }

        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        //Constructors //CTORS //FQCTOR
        //Conventions: public and camelCase params
        //Rules: Must match the class name -> spelling, and casing
        //FQCTOR: Fully Qualified Constructor
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
          //Property       "is assigned the value of"     param
            FirstName               =                   firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        //Methods 
        //old-school ToString
        //public override string ToString()
        //{
        //    return $"Name: {FirstName} {LastName}\n" + 
        //        $"Date Of Birth: {DateOfBirth:d}";

        //}

        //C# arrow function same as above 
        public override string ToString() => // => is read as "evaluates to" 
            $"Name: {FirstName} {LastName}\nDate of Birth: {DateOfBirth:d}";


    }//end class
}//end namespace
