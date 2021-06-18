using System;
//Saleperson namespace
namespace Saleperson 
{
    //abstract class Salesperson, so that it cannot be instantiated
    abstract class Salesperson
    {
        //name and string values that will be set with values
        public string name {get; set;} = "Brandon";
        public string last {get;set;} = "Lopez";
        //Constructors
        public Salesperson(){}

        public Salesperson(string firstName, string lastName)
        {
            firstName = name;
            lastName = last;
        }
        //displayName() method will be used to return the salespersons full name
        public void displayName()
        {
            Console.WriteLine("The name of the Salesperson is: {0} {1}\n",name, last);
        }

    }

}
