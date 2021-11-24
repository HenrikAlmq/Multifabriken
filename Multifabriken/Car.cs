using System;
using System.Collections.Generic;

namespace Multifabriken
{
    class Car : Order
    {      
        private string inputReg;
        private string inputCar;

        public Car(string aInputReg, string aInputColor, string aInputCar)
        {
            inputReg = aInputReg;
            inputColor = aInputColor;
            inputCar = aInputCar;
        }


        public override void showOrder()
        {
            Console.WriteLine($"Du har valt att beställa en bil med regnummer: {inputReg.ToUpper()}, färg: {inputColor} och bilmärke: {inputCar}");
        }

        


       

    }

}