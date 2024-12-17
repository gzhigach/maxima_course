using System;

namespace ConsoleApp8
{
    public class CoffeeMachine
    {
        public void MakeCoffee(string coffeeType)
        {
            switch  (coffeeType)
            {
                case "эспрессо":
                    PrepareEspresso();
                    break;
                case "американо":
                    PrepareAmericano();
                    break;
                case "капучино":
                    PrepareCappuccino();
                    break;
                case "латте":
                    PrepareLatte();
                    break;
                case "мокко":
                    PrepareMocha();
                    break;
                default:
                    Console.WriteLine("Такого вида кофе нет в меню.");
                    break; 
            }
        }

        public void PrepareEspresso()
        {
            Console.WriteLine("Готовим Эспрессо...");
            Console.WriteLine("Эспрессо готов!");
        }

        public void PrepareAmericano()
        {
            Console.WriteLine("Готовим Американо...");
            Console.WriteLine("Американо готово!");
        }

        public void PrepareCappuccino()
        {
            Console.WriteLine("Готовим Капучино...");
            Console.WriteLine("Капучино готово!");
        }

        public void PrepareLatte()
        {
            Console.WriteLine("Готовим Латте...");
            Console.WriteLine("Латте готово!");
        }

        public void PrepareMocha()
        {
            Console.WriteLine("Готовим Мокко...");
            Console.WriteLine("Мокко готово!");
        }
    }
}