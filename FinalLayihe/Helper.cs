using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLayihe
{
    internal class Helper
    {      
        public void Method(string info)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor =ConsoleColor.Blue;
            Console.Write(" ".PadLeft(20, ' '));
            for (int i = 0; i < info.Length; i++)
            {   Console.Write(info[i]);
                Thread.Sleep(5);
            }
            Console.WriteLine();
        }
        public void Method1(string info)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" ".PadLeft(20, ' '));
            for (int i = 0; i < info.Length; i++)
            {
                Console.Write(info[i]);
                Thread.Sleep(5);
            }
            Console.WriteLine();
        }
        public void Method2(string info)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" ".PadLeft(20, ' '));
            for (int i = 0; i < info.Length; i++)
            {
                Console.Write(info[i]);
                Thread.Sleep(5);
            } 
        }
        public void Method3(string info)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" ".PadLeft(20, ' '));
            for (int i = 0; i < info.Length; i++)
            {
                Console.Write(info[i]);
                Thread.Sleep(5);
            }
            Console.WriteLine();
        }
        public void Method4(string info)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ".PadLeft(20, ' '));
            for (int i = 0; i < info.Length; i++)
            {
                Console.Write(info[i]);
                Thread.Sleep(5);
            }
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine();
        }
        public T Method5<T>()
        {
            object result;
            Type type = typeof(T);
            Console.ForegroundColor = ConsoleColor.Green;
            var data = Enum.GetValues(type);
            foreach (var item in data)
            {
                byte number = (byte)item;
                string data1 = $"{number}.{item} ucun emeliyyat.";
                for (byte i = 0; i < data1.Length; i++)
                {
                    Console.Write(data1[i]);
                    Thread.Sleep(5);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
        l1: Method2("Secim edin: ");
            if (!Enum.TryParse(type, Console.ReadLine(), true, out result))
            {
                Method1("Yalnis melumat daxil edildi ! Yalniz Menyudan Id daxil edin.");
                goto l1;
            }
            if (!Enum.IsDefined(type, result))
            {
                Method1("Yalnis melumat daxil edildi ! Yalniz Menyudan Id daxil edin.");
                goto l1;
            }
            Method1("Zehmet olmasa gozleyin emeliyyat yuklenir... ");
            Thread.Sleep(2000);
            Method4("Emeliyyat hazirdir !");
            Thread.Sleep(2000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            return (T)result;
        }
        public void Method6(string info)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < info.Length; i++)
            {
                Console.Write(info[i]);
                Thread.Sleep(5);
            }
        }
        public int Method7(string info)
        {
            int result;
            var color = Console.ForegroundColor;
           l1: Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < info.Length; i++)
            {
                Console.Write(info[i]);
                Thread.Sleep(5);
            }
            if (!int.TryParse(Console.ReadLine(),out result)||result<1)
            {
                Method1("Duzgun Id secilmedi !");
                goto l1;
            }
            return result;
        }
        public void Method8(string info)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < info.Length; i++)
            {
                Console.Write(info[i]);
                Thread.Sleep(5);
            }
            Console.WriteLine();
        }
        public int ReadInt(string data)
        {
            int result;
        l1:
            if (!int.TryParse(Readstring(data), out result))
            {
                Method1("Yalniz tam reqem daxil edin !");
                goto l1;
            }
            return result;
        }
        public decimal ReadDecimal(string data)
        {
           l1:
            decimal result;
            if (!decimal.TryParse(Readstring(data), out result))
            {
                Method1("Yalniz reqem daxil edin.");
                goto l1;
            }
            return result;
        }       
        public string Readstring(string data)
        {
           l1: Method6(data);
            Console.ForegroundColor = ConsoleColor.Green;
            string result=Console.ReadLine();
            if (string.IsNullOrWhiteSpace(result))
            {
                Method1("Bu xanani bos buraxmaqa icaze verilmir !");
                goto l1;
            }
            var color = Console.ForegroundColor;
            return result;
        }
        public void ReadBool()
        {
            Method("Ekran temizlemek ucun <<ENTER>> sixin>>");
            var key= Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Method1("Ekran silinir....");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        public bool Readbool()
        {
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                return true;
            }
            return false;
        }

       
    }
}
