using System;
//Use the Salesperson class to to instantiate objects using the class
using Saleperson;
//Create a salesPerson1 object instatiated from the RealEstateSalesperson class
RealEstateSalesperson salesPerson1 = new();
//Create a girlscout1 object instatiated from the GirlScout class
GirlScout girlscout1 = new();
//call the displayName method located in the Salesperson class
salesPerson1.displayName();
//call the SalesSpeech method located in the ISellable interface and defined in the RealEstateSalesPerson class
salesPerson1.SalesSpeech();
// set the dollarvalue of the house sold using the MakeSale method. The results will be displayed
salesPerson1.MakeSale(salesPerson1.dollarValue = 45000);
// set a new dollarvalue of a house sold using the MakeSale method. The results will be displayed
salesPerson1.MakeSale(salesPerson1.dollarValue = 55000);
//Call the SalesSpeech method defined in the girlscout class
girlscout1.SalesSpeech();
//set the number of cookies sold using the MakeSale method. The results will be displayed
girlscout1.MakeSale(girlscout1.cookiesSold = 3);
girlscout1.MakeSale(girlscout1.cookiesSold = 4);
//Create a for loop that will start from 1 and go to 3. The i variable will be set as number of boxes sold
for (int i = 1; i < 4; i++)
{
    girlscout1.cookiesSold = i;
    girlscout1.MakeSale(girlscout1.cookiesSold);

}