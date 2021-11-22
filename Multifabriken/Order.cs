using System;
using System.Collections.Generic;

namespace Multifabriken
{
    abstract class Order //superklass
    {
        protected string inputColor;
        protected int inputPcs;
        //en metod som går att skriva över i subklasserna
        public abstract void showOrder();

        
    }
}