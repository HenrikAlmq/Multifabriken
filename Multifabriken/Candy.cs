using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Candy : Order
    {
        private string InputFlavor;

        public Candy(string aInputFlavor, int aInputPcsCandy)
        {
            InputFlavor = aInputFlavor;
            inputPcs = aInputPcsCandy;
        }

        public override void showOrder()
        {
            Console.WriteLine($"Du har valt att beställa godis med smak: {InputFlavor} och antal styck: {inputPcs}");
        }
    }
}