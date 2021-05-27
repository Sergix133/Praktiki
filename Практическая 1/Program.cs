using System;

namespace ConsoleApp71
{
    public class lib1
    {
        public static void stpow(string a,int b)
        {
           string s = "";
            for (int i= 0;i<b;i++)
            {
                s += a;
            }
            Console.WriteLine(s);
        }
        public static void rev(string a)
        {
            char[] s = a.ToCharArray();
            Array.Reverse(s);
            string b = "";
            for(int i = 0; i < s.Length; i++)
            {
                b += s[i];
            }
            Console.WriteLine(b);
        }
        public static void remove(string a,string b)
        {
            string s;
            s = a.Replace(b, "");
            Console.WriteLine(s);
        }
        public static void leng(string stroka)
        {
            int a = stroka.Length;
            Console.WriteLine(a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int b;
            int v;
            Console.WriteLine("Выберите метод\n1 - для stropw\n2 - для rev\n3 - для remove\n4 - для leng");
            v = Convert.ToInt32(Console.ReadLine());
            switch (v)
            {
                case 1:
                    Console.WriteLine("Введите значения");
                    a = Convert.ToString(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    //stropw
                    lib1.stpow(a, b);

                    break;
                case 2:
                    Console.WriteLine("Введите строку");
                    a = Convert.ToString(Console.ReadLine());
                    lib1.rev(a);
                    //rev
                    break;
                case 3:
                    //remove
                    Console.WriteLine("Введите значения");
                    a = Convert.ToString(Console.ReadLine());
                    string n = "";
                    n = Convert.ToString(Console.ReadLine());
                    lib1.remove(a, n);
                    break;
                case 4:
                    //leng
                    Console.WriteLine("Введите строку");
                    string stroka;
                    stroka = Convert.ToString(Console.ReadLine());
                    lib1.leng(stroka);
                    break;
            }
        }
    }
}
