using System;

namespace Saleperson 
{
    //GirlScout class derived from the Salesperson class and ISellable interface
    class GirlScout : Salesperson, ISellable
    {
        //cookiesSold variable will hold the number of cookies sold for one object
        public int cookiesSold{get; set;} = 0;
        //total variable will hold the total number of cookies sold everytime the object is called in the program
        public int total{get;set;} = 0;

        //Constructors
        public GirlScout() {}

        public GirlScout(int cookies, int totals) 
        {
            cookiesSold = cookies;
            total = totals;
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
            Console.WriteLine("\nGirl Scout cookie Sales");
            Console.WriteLine("\nWith hard work and dedication, you can sale cookies!!!");
        }

         //The MakeSale method will accept the numberBoxes variable
        public void MakeSale(int numberBoxes)
        {
            //numberBoxes will equal the amount of cookies sold
            numberBoxes = cookiesSold;
            //The number of boxes will be added to the total everytime the object is ran in the program
            total += numberBoxes;
            //Display the total on the screen
            Console.WriteLine("\nThe number of cookie boxes sold is : {0}", cookiesSold);

            Console.WriteLine("\nThe total cookies sold is: {0}",total);

            Console.WriteLine("-----------------------------------------------------");



        }

        
    }





    
            


}
