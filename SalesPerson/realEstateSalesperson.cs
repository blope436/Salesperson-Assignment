using System;

namespace Saleperson 
{
    //RealEstateSalesperson class will be a child class of Salesperson and the ISellable interface
    //The ISellable interface is needed to implement it's methods SalesSpeech() and MakeSale()
    class RealEstateSalesperson : Salesperson, ISellable
    {
        //totalValue field will be set to 0 and hold the totalValue of houses sold
        public int totalValue{get;set;} = 0;
        //totalCommission will be set to 0 and hold the total commission value earned
        public double totalCommission{get;set;} = 0;
        //commissionRate will be set to 0.06 to indicate a commission rate of 6%
        public double commissionRate{get; set;} = 0.06;
        //dollarValue will be set to 0 and hold the cost of one house, it is set to 0 and will be set in Program.cs
        public int dollarValue{get;set;} = 0;

        //Constructors
        public RealEstateSalesperson() {}
        //Constructor will hold the commissionRate
        public RealEstateSalesperson(double rate) 
        {
            commissionRate = rate;

        }
        public void Salesperson(){}

        public void Salesperson(string firstName, string lastName)
        {
            firstName = name;
            lastName = last;
        }
        //The SaleSpeech method from the ISellable interface will be used and set with text
        public void SalesSpeech()
        {
            Console.WriteLine("With hard work and dedication, you can make a sale!!!");
        }

        //The MakeSale method will accept the dollarValues variable
        public void MakeSale(int dollarValues)
        {
            //dollarValue will equal dollarValues
            dollarValue = dollarValues;
            //Add the dollarvalue to the total until there is no more to add     
            totalValue += dollarValues;
            //The commission rate will be calulated by multiplying commissionRate by totalValue
            //It will be stored in the totalCommission variable
            totalCommission = commissionRate * totalValue;
            //Display the results on the screen
            Console.WriteLine("\nThe dollar value of the house is : {0}", dollarValues);

            Console.WriteLine("\nThe total value sold for {0} {1} is : {2}",name,last,totalValue);

            Console.WriteLine("\nThe total commission earned is: {0}",totalCommission);

            Console.WriteLine("-----------------------------------------------------");



        }
      
       

    }


    
        

}
