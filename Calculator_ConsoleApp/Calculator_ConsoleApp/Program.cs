using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber;
            int SecondNumber;
            int OperationType;
            string exit_txt;
            bool exit = true;
            bool key_control = false;
            do//Çıkış yapılmaz ise işlemlerin tekrarı.
            {
                Console.Write("First Number=");
                while (!int.TryParse(Console.ReadLine(), out FirstNumber))//İlk sayıyı alma ve sayı olduğundan emin olma.
                {
                    Console.WriteLine("Please enter a number.");
                    Console.Write("First Number=");
                }
                Console.Write("Second Number=");
                while (!int.TryParse(Console.ReadLine(), out SecondNumber))//İkinci sayıyı alma ve sayı olduğundan emin olma.
                {
                    Console.WriteLine("Please enter a number.");
                    Console.Write("Second Number=");
                }
                Console.WriteLine("1. Sum\n2. Subtract\n3. Multiply\n4. Divide\nOperation Type Number=");
                while (!int.TryParse(Console.ReadLine(), out OperationType) || OperationType < 0 || OperationType > 4)//İşlem tipini belli etme ve doğru giriş yapıldığını kontrol etme.
                {
                    Console.WriteLine("Please enter a number.");
                    Console.Write("1. Sum\n2. Subtract\n3. Multiply\n4. Divide\nOperation Type Number=");
                }
                switch (OperationType)//Seçilen işlem tipine göre metoda yönlendirme.
                {
                    case 1:
                        sum(FirstNumber, SecondNumber);
                        break;
                    case 2:
                        Subtract(FirstNumber, SecondNumber);
                        break;
                    case 3:
                        Multiply(FirstNumber, SecondNumber);
                        break;
                    case 4:
                        Divide(FirstNumber, SecondNumber);
                        break;
                }
                do//Girilen verinin kontrolü ve hatalı giriş olursa tekrar giriş istenmesi.
                {
                    Console.WriteLine("Exit?(Y/N)");
                    exit_txt = Console.ReadLine();
                    if (exit_txt == "Y" || exit_txt == "y")
                    {
                        key_control = false;
                        exit = false;
                    }
                    else if (exit_txt == "N" || exit_txt == "n")
                    {
                        key_control = false;
                        exit = true;
                    }
                    else
                    {
                        key_control = true;
                        Console.WriteLine("Wrong key, try again.");
                    }
                } while (key_control);

            } while (exit);

        }

        public static void sum(int FirstNumber, int SecondNumber)//Toplama.
        {
            int Result = FirstNumber + SecondNumber;
            Console.Clear();
            Console.WriteLine(FirstNumber.ToString() + " + " + SecondNumber.ToString() + " = " + Result.ToString());
        }
        public static void Subtract(int FirstNumber, int SecondNumber)//Çıkarma.
        {
            int Result = FirstNumber - SecondNumber;
            Console.Clear();
            Console.WriteLine(FirstNumber.ToString() + " - " + SecondNumber.ToString() + " = " + Result.ToString());
        }
        public static void Multiply(int FirstNumber, int SecondNumber)//Çarpma.
        {
            int Result = FirstNumber * SecondNumber;
            Console.Clear();
            Console.WriteLine(FirstNumber.ToString() + " * " + SecondNumber.ToString() + " = " + Result.ToString());
        }
        public static void Divide(int FirstNumber, int SecondNumber)//Bölme.
        {
            int Result = FirstNumber / SecondNumber;
            Console.Clear();
            Console.WriteLine(FirstNumber.ToString() + " / " + SecondNumber.ToString() + " = " + Result.ToString());
        }
    }
}

