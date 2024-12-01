using System.ComponentModel.Design;
using System.Reflection;

namespace FirstProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Камень");
            Console.WriteLine("2 - Ножницы");
            Console.WriteLine("3 - Бумага");

            Console.WriteLine("Введите название команды для игрока 1");

            string text1 = Console.ReadLine();
            int player1 = default;
            bool result1 = int.TryParse(text1, out player1);

            Console.WriteLine("Введите название команды для игрока 2");

            string text2 = Console.ReadLine();
            int player2 = default;
            bool result2 = int.TryParse(text2, out player2);


            if ( (result1 == true && result2 == true) && (player1 > 0 && player1 <= 3) && (player2 > 0 && player2 <= 3))
            {
              
                if (player1 == player2)
                {
                    Console.WriteLine("Ничья");
                }

                else if (player1 == 1 && player2 == 2 || player1 == 2 && player2 == 3 || player1 == 3 && player2 == 1)
                {
                    Console.WriteLine("1 игрок выиграл");
                }
                else
                {
                    Console.WriteLine("2 игрок выиграл");
                }

                Console.ReadKey();
            }
           else
            {
                Console.WriteLine("Ошибка. Указана недопустимая команда");
            }
        }
    }
}