using System;

namespace Saleperson 
{
    //ISellable interface that will containe two methods
    //One will dipsplay text and the other will accept an integer value and display results on screen
    public interface ISellable
    {
        void SalesSpeech();

        void MakeSale(int dollarValue);
    }


}