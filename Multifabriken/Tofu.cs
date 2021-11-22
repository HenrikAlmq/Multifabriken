using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Tofu : Order
    {
        private string inputSpice;

        public Tofu(int aVolume, string aSpice)
        {
            inputPcs = aVolume;
            inputSpice = aSpice;         
        }

        public override void showOrder()
        {
            Console.WriteLine($"Du har beställt Tofu med smak: {inputSpice} i mängd {inputPcs}L");
        }  
    }
}