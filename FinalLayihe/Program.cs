using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace FinalLayihe
{
    internal class Program
    {
        static void GetAllAuthor()
        {
            foreach (var item in autor)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            
            Helper M1 = new Helper();
            M1.Method("Salam. Siz Menyu secmelisiz.");
            M1.Method("Menyudaki emeliyyatlara nezer yetrin.");
            byte number = (byte)M1.Method5<Menyu>();
            if (number == 1)
            {
               l1: M1.Method("<<Acilan menyunun ID ile secim ede bilersiz>>>>");
                GenericsStore<AuthorClass> G1 = new GenericsStore<AuthorClass>();
                G1.Add(new AuthorClass { Name = "Samir", Surname = "Xasiyev" });
                G1.Add(new AuthorClass { Name = "Salam", Surname = "Doslar" });
                G1.Add(new AuthorClass { Name = "Alooo", Surname = "bellli" });
                AuthorClass author = new AuthorClass();
                
                int number1 = (byte)M1.Method5<AuthorEnum>();
                AuthorClass data;
                switch (number1)
                {
                    case 1:
                        M1.Method2("<<Zehmet olmasa acilan melumatlari doldurun>>>");
                        Console.WriteLine();
                        string name = M1.Readstring("Adiniz:");
                        string surname = M1.Readstring("Soyadiniz:");
                        G1.Add(new AuthorClass { Name = name, Surname = surname });
                        Console.Clear();
                        M1.Method4("<<<<<<Eeliyyyat ugurla yerine yetrildi>>>>>>");
                        M1.Method3("Menyuya geri donus olunur....");
                        Thread.Sleep(5000);
                        Console.Clear();
                        goto l1;
                    case 2:
                        M1.Method2("Diqqet siz her hansi bir melumati Id ile oxuya bilersiz !");                       
                        Console.WriteLine();
                        Console.WriteLine();
                        int index = M1.Method7("Oxumaq isdediyiniz datanin ID daxil edin::");
                        data =G1.GetId(index);
                        Console.WriteLine();
                        M1.ReadBool();
                        Console.WriteLine();
                        goto l1;
                    default:
                        break;
                }
                
                //    else if (number1==2)
                //    {
                //        M1.Method2("Diqqet siz her hansi bir melumati sile bilersiz burda !");
                //        Console.WriteLine();
                //        Console.WriteLine();
                //        int index=M1.Method7("Silmek isdediyiniz datanin ID daxil edin::");
                //        data=G1.GetId(index);
                //        G1.Remove(data);



                //    }
                //}
                //else if (number == 2)
                //{
                //    M1.Method("<<Acilan menyunun ID ile secim ede bilersiz>>>>");
                //    GenericsStore<AuthorClass> G1 = new GenericsStore<AuthorClass>();
                //    int number1 = (byte)M1.Method5<BookEnum>();
            }


        }
        
    }
}