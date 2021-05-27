using System;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая 2 задание 1");
            Console.WriteLine("Введите строку");
            string stroka;
            int a = 0;
            int b = 0;
            stroka = Convert.ToString(Console.ReadLine()).ToLower();
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == 'f')
                {
                    a++;
                    b += i;
                    if (a == 2)
                    {
                        Console.WriteLine("Индекс вхождения f =" + b);
                    }

                }
            }
            if (a == 1)
            {
                Console.WriteLine("-1");
            }
            if (a == 0)
            {
                Console.WriteLine("-2");
            }
            Console.WriteLine("Практическая 2 задание 2");
            Console.WriteLine("Введите строку");
            string stroka1 = Convert.ToString(Console.ReadLine()).ToLower();
            string stroka2 = " ";
            string[] mas = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я", " " };
            string[] mas1 = { "a", "b", "v", "g", "d", "e", "yo", "j", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h", "c", "ch", "sh", "sh", "", "y", "", "e", "yu", "ya", " " };
            for (int i = 0; i < stroka1.Length; i++)
            {
                for (int j = 0; j < mas.Length; j++)
                {
                    if (Convert.ToString(stroka1[i]) == mas[j])
                    {
                        stroka2 = stroka2 + mas1[j];
                    }
                }
            }
            Console.WriteLine(stroka2);
            Console.WriteLine("Задание 3");
            string stroka3 = Convert.ToString(Console.ReadLine());
            string stroka4 = "";
            int a1 = 0, a2 = 0;
            for (int i = 0; i < stroka3.Length; i++) 
            {
                if (stroka3[i] == 'h') a1++; 
            }
            for (int j = 0; j < stroka3.Length; j++) 
            {
                if (stroka3[j] == 'h') 
                {
                    if (a2 != 0 && a2 != a1 - 1)
                    {
                        stroka4 += "H";
                    }
                    else stroka4 += "h"; a2++; 
                } 
                else stroka4 += stroka3[j]; 
            }
            Console.WriteLine(stroka4);
        }
    }
}
