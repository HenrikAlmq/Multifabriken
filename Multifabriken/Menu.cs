using System;
using System.Collections.Generic;

namespace Multifabriken
{
    public class Menu
    {
        public void RunMulti()
        {
            List<Order> Products = new List<Order>();
            bool restart = true;
            do
            {
                Console.Clear();
                Console.WriteLine("***Multifabriken***");
                Console.WriteLine("Nedan listar vi ut de olika val som finns hos oss på Multifabriken, vänligen gör ett val!");
                Console.WriteLine("[1] - Bil");
                Console.WriteLine("[2] - Godis");
                Console.WriteLine("[3] - Snören");
                Console.WriteLine("[4] - Tofu");
                Console.WriteLine("[5] - Lista alla beställningar");
                Console.WriteLine("[6] - Avsluta");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Vänligen fyll i registreringsnumret:");
                        string inputReg = Console.ReadLine();
                        Console.WriteLine("Vänligen välj vilken färg du vill ha på bilen:");
                        string inputColorCar = Console.ReadLine();
                        Console.WriteLine("Vänligen välj vilket bilmärke vi skall skapa:");
                        string inputCar = Console.ReadLine();
                        Car newCar = new Car(inputReg, inputColorCar, inputCar);
                        Products.Add(newCar);
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Vänligen ange vilken smak du önskar:");
                        string inputFlavor = Console.ReadLine();
                        Console.WriteLine("Vänligen ange antal styck(heltal) du vill beställa:");
                        int inputPcsCandy = ValidateNum();
                        Candy newCandy = new Candy(inputFlavor, inputPcsCandy);
                        Products.Add(newCandy);
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Vänligen ange vilken längd i M(heltal) du önskar:");
                        int inputLength = ValidateNum();
                        Console.WriteLine("Vänligen ange vilken färg du önskar:");
                        string inputColorLace = Console.ReadLine();
                        Lace newLace = new Lace(inputLength, inputColorLace);
                        Products.Add(newLace);
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Vänligen ange hur stor volym i L(heltal) du vill beställa:");
                        int inputVolume = ValidateNum();
                        Console.WriteLine("Vänligen ange vilken kryddblandning du önskar:");
                        string inputSpice = Console.ReadLine();
                        Tofu newTofu = new Tofu(inputVolume, inputSpice);

                        Products.Add(newTofu);
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Nedan produkter är beställda:");
                        foreach (Order product in Products)
                        {
                            product.showOrder();
                        }
                        Console.WriteLine("Tryck på valfri knapp för att återgå till huvudmenyn");
                        Console.ReadLine();
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("Tack för att du har använt MultiFabriken, tryck på valfri knapp för att avsluta!");
                        Console.ReadLine();
                        restart = false;
                        break;

                }
            } while (restart);
        }

        private int ValidateNum()
        {
            int number;

            bool parseCheck = int.TryParse(Console.ReadLine(), out number);

            while (!parseCheck)
            {
                Console.WriteLine("Vänligen ange en siffra (heltal)");
                parseCheck = int.TryParse(Console.ReadLine(), out number);
            }

            return number;
        }
    }
}