using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Lace : Order
    {
        
        public Lace(int aInputLength, string ainputColor)
        {
            inputPcs = aInputLength;
            inputColor = ainputColor;
        }

        public override void showOrder()
        {
            Console.WriteLine($"Du har beställt ett snöre med längd: {inputPcs}M och färg: {inputColor}");
        }

        
    }
}