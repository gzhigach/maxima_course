

/*
Программа определяет является ли указанное целое число number палиндромом без использования строк.
Для этого в массив целых чисел arr1 записываются цифры, начиная с конца числа number. Чтобы получить последнюю цифру используется %10.
Чтобы получить цифру перед последней число сначала делится на 10 в степени 0, затем на 10 в степени 1 и т.д.
Для определения размера массива вычисляется количество цифр в числе путем деления на 10 и записывается в digitCount.
 */

namespace FirstProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = 123321;
            int numberCopy = number;
            int digitCount = 0;
            bool nopalindrom = default;

            if (number == 0)
            {
                digitCount = 1; 
            }
            
            else
            {
                while (number > 0)
                {
                    number /= 10; 
                    digitCount++; 
                }
            }

            int[] arr1 = new int[digitCount];
            
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = numberCopy / ((int)Math.Pow(10, i)) % 10;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                int reverseIndex = arr1.Length - 1 - i;

                if (arr1[i] != arr1[reverseIndex])
                {
                    nopalindrom = true;
                }
 
            }
            
            if (nopalindrom) 
            { 
                Console.WriteLine("Не палиндром"); 
            }
            else
            {
                Console.WriteLine("Палиндром");
            }

                }
    }
    
}