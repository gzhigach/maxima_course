using System;

namespace ConsoleApp8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();

            Console.WriteLine("Введите вид кофе (эспрессо, американо, капучино, латте, мокко):");
            string coffeeType = Console.ReadLine();

            coffeeMachine.MakeCoffee(coffeeType);
        }
    }
}