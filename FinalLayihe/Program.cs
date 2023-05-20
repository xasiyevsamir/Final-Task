using System;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;

namespace FinalLayihe
{
    internal class Program
    { 
       const string datafayll = "database.dat";
        static GenericStore<AuthorClass> G1 = new GenericStore<AuthorClass>();
        static GenericStore<BooKClass> G2 = new GenericStore<BooKClass>();
        static void Main(string[] args)
        {
           h1:
            try
            {
                using (var fs = File.Open(datafayll, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    Database db = bf.Deserialize(fs) as Database;
                    if (db != null)
                    {
                        G1 = db.Author;
                        G2 = db.Book;
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Baza bosdur !");
            }
            BooKClass book;
            AuthorClass author;
            Helper M1 = new Helper();
        l6: M1.Method("Salam. Siz Menyu secmelisiz.");
            M1.Method("Menyudaki emeliyyatlara nezer yetrin.");
            byte number = (byte)M1.Method5<Menu>();
            int index = 0;
            if (number == 1)
            {
            l1: M1.Method("<<Acilan Author menyusunda ID ile secim ede bilersiz>>>>");
                int number1 = (byte)M1.Method5<AuthorEnum>();

                switch (number1)
                {
                    case 1:
                        M1.Method2("<<Zehmet olmasa acilan melumatlari doldurun>>>");
                        Console.WriteLine();
                        string name = M1.Readstring("Adiniz:");
                        string surname = M1.Readstring("Soyadiniz:");
                        Console.WriteLine(G1.Count);
                        G1.Add(new AuthorClass { Name = name, Surname = surname });

                        Console.Clear();
                        M1.Method4("<<<<<<Melumat ugurla daxil edildi>>>>>>");
                        M1.Method3("Menyuya geri donus olunur....");
                        Thread.Sleep(3000);
                        Console.Clear();
                        goto l1;

                    case 2:
                        if (G1.Count == 0)
                        {
                            M1.Method1("Author yoxdur zehmet olmasa elave edin.");
                            goto case 1;
                        }
                        M1.Method2("Diqqet ! Siz her hansi bir melumati Id ile oxuya bilersiz !");
                        Console.WriteLine();
                    l3: M1.Method8("Qeyd: Eger Id-ni unutmusuzsa buradan baxa bilersiz ! ID Cap edilsin<Enter>");
                        if (M1.Readbool())
                        {
                            GetAllAuthorId();
                        }
                        index = M1.Method7("Oxumaq isdediyiniz datanin ID daxil edin:");
                        author = G1.GetId(index);
                        if (author != null)
                        {
                            Console.Clear();
                            M1.Method8($"Daxil edilen ID-e uygun melumat .\nId:{author.Id}\nAd:{author.Name}\nSoyad:{author.Surname}");
                            M1.ReadBool();
                            Console.WriteLine();
                            goto l1;
                        }
                        else
                        {
                            M1.Method1("Bu Id-e uygun melumat sistemde yoxdur. Basqasini daxil et !");
                            Thread.Sleep(3000);
                            Console.Clear();
                            goto l3;
                        }
                    case 3:

                        if (G1.Count == 0)
                        {
                            M1.Method1("Author yoxdur zehmet olmasa elave edin.");
                            goto case 1;
                        }
                    l4: M1.Method3("<<<Diqqet siz her hansi bir melumati Id ile yeniliye bilersiz !");
                        Console.WriteLine();
                        M1.Method8("Qeyd: Eger Id-ni unutmusuzsa buradan baxa bilersiz ! ID Cap edilsin<Enter>");
                        if (M1.Readbool())
                        {
                            GetAllAuthorId();
                        }
                        index = M1.Method7("Yenilemek isdediyiniz datanin ID daxil edin:");
                        author = G1.GetId(index);
                        if (author != null)
                        {
                            author.Name = M1.Readstring("Yeni Ad:");
                            author.Surname = M1.Readstring("Yeni Soyad:");
                            M1.ReadBool();
                            M1.Method4("Melumat ugurla yenilendi.");
                            Thread.Sleep(2000);
                        }
                        else { M1.Method1("Yenilemek isdediyiniz Id tapilmadi !"); Thread.Sleep(3000); Console.Clear(); goto l4; }
                        Console.Clear();
                        goto l1;

                    case 4:
                        if (G1.Count == 0)
                        {
                            M1.Method1("Author yoxdur zehmet olmasa elave edin.");
                            goto case 1;
                        }
                        M1.Method8("Butun datalara nece saniye baxacaqsan ?");
                        int seconds = M1.ReadInt("Saniye secin:");
                        GetAllAuthor();
                        seconds = seconds * 1000;
                        Thread.Sleep((int)seconds);
                        Console.Clear();
                        goto l1;
                    case 5:
                        if (G1.Count == 0)
                        {
                            M1.Method1("Author yoxdur zehmet olmasa elave edin.");
                            goto case 1;
                        }
                    l5: M1.Method3("<<<Diqqet siz her hansi bir melumati Id ile sile bilersiz !");
                        Console.WriteLine();
                        M1.Method8("Qeyd: Eger Id-ni unutmusuzsa buradan baxa bilersiz ! ID Cap edilsin<Enter>");
                        if (M1.Readbool())
                        {
                            GetAllAuthorId();
                        }
                        index = M1.Method7("Silmek isdediyiniz datanin Id daxil edin:");
                        author = G1.GetId(index);
                        if (author != null)
                        {
                            RemoveIndex(index);
                            G1.Remove(author);
                        }
                        else { M1.Method1("Silmek isdediyiniz Id tapilmadi !"); Thread.Sleep(3000); Console.Clear(); goto l5; }
                        Console.Clear();
                        M1.Method4("Melumat ugurla silindi.");
                        goto l1;
                    case 6:
                        Console.Clear();
                        goto l6;
                }
            }
            else if (number == 2)
            {
            l3: M1.Method("<<Acilan Book menyusunda ID ile secim ede bilersiz>>>>");
                int number1 = (byte)M1.Method5<BookEnum>();
                switch (number1)
                {
                    case 1:
                        if (G1.Count == 0)
                        {
                            M1.Method1("Author yoxdur zehmet olmasa elave edin.");
                            Thread.Sleep(3000);
                            Console.Clear();
                            goto l6;
                        }
                        M1.Method2("<<Zehmet olmasa acilan melumatlari doldurun>>>");
                        Console.WriteLine();
                        M1.Method3("Author id-sini asagidakilardan sece bilersiz !");
                        GetAllAuthor();
                    l1: int id = M1.ReadInt("Author id:");
                        author = G1.GetId(id);
                        if (author == null)
                        {
                            M1.Method1("Daxil etdiyiniz id tapilmadi yeniden siyahidan secin !");
                            goto l1;
                        }
                        else
                        {
                            string name = M1.Readstring("Kitabin adi:");
                            int number4 = M1.ReadInt("Kitabin sehve sayi:");
                            decimal number5 = M1.ReadDecimal("Kitabin qiymeti:");
                            Console.WriteLine();
                            M1.Method6("Kitabin janrini secin !");
                            Console.WriteLine();
                            Genre number3 = M1.Method5<Genre>();
                            G2.Add(new BooKClass { Name = name, AuthorId = id, Genre = number3, PageGCount = number4, Price = number5 });
                            M1.Method4("<<<<<<Melumat ugurla daxil edildi>>>>>>");
                            M1.Method3("Menyuya geri donus olunur....");
                            Thread.Sleep(3000);
                            Console.Clear();
                            goto l3;
                        }
                    case 2:
                        if (G2.Count == 0)
                        {
                            M1.Method1("Kitab yoxdur zehmet olmasa elave edin.");
                            Thread.Sleep(3000);
                            Console.Clear();
                            goto case 1;
                        }
                        M1.Method2("Diqqet ! Siz her hansi bir melumati Id ile oxuya bilersiz !");
                        Console.WriteLine();
                        M1.Method8("Qeyd: Eger Id-ni unutmusuzsa buradan baxa bilersiz ! ID Cap edilsin<Enter>");
                        if (M1.Readbool())
                        {
                            GetAllBookId();
                        }
                    l4: index = M1.Method7("Oxumaq isdediyiniz datanin ID daxil edin:");
                        book = G2.GetId(index);
                        if (book != null)
                        {
                            Console.Clear();
                            author = G1.GetId(book.AuthorId);
                            if (author != null)
                            {
                                M1.Method8($"Daxil edilen ID-e uygun melumat .\nAuthorId:{author.Id}\nAuthor Adi:{author.Name}\nAuthor Soyad:{author.Surname}\n\nKitabin Id:{book.Id}\nKitabin adi:{book.Name}\nSehve sayi::{book.PageGCount}\nQiymeti:{book.Price}\nJanri:{book.Genre}");
                                M1.ReadBool();
                                Console.WriteLine();
                                goto l3;
                            }
                            else
                            {
                                G2.Remove(book);
                                M1.Method1($" Id {book.Id} olan book sistemden silinib. ");
                                Thread.Sleep(3000);
                                Console.Clear();
                                goto l3;
                            }
                        }
                        else
                        {
                            M1.Method1("Bu Id-e uygun melumat sistemde yoxdur. Basqasini daxil et !");
                            Thread.Sleep(3000);
                            goto l4;
                        }
                    case 3:
                        if (G2.Count == 0)
                        {
                            M1.Method1("Kitab yoxdur zehmet olmasa elave edin.");
                            Thread.Sleep(3000);
                            Console.Clear();
                            goto case 1;
                        }
                        M1.Method3("<<<Diqqet siz her hansi bir melumati Id ile yeniliye bilersiz !");
                        Console.WriteLine();
                        M1.Method8("Qeyd: Eger Id-ni unutmusuzsa buradan baxa bilersiz ! ID Cap edilsin<Enter>");
                        if (M1.Readbool())
                        {
                            GetAllBookId();
                        }
                    l5: index = M1.Method7("Yenilemek isdediyiniz datanin ID daxil edin:");
                        book = G2.GetId(index);
                        if (book != null)
                        {
                            M1.Method1("Yenilemek isdediyiniz Id-de asagidaki melumatlar var");
                            Console.WriteLine($"Kitabin Id:{book.Id}\nKitabin adi:{book.Name}\nSehve sayi::{book.PageGCount}\nQiymeti:{book.Price}\nJanri:{book.Genre}");
                            Console.WriteLine("Yenilemek ucun melumatlari doldurun !");
                            Console.WriteLine();
                            book.Name = M1.Readstring("Yeni Ad:");
                            book.PageGCount = M1.ReadInt("Kitabin sehve sayi:");
                            book.Price = M1.ReadDecimal("Kitabin qiymeti:");
                            Console.WriteLine();
                            M1.Method6("Kitabin janrini secin !");
                            Console.WriteLine();
                            book.Genre = M1.Method5<Genre>();
                            M1.Method4("Melumat ugurla yenilendi.");
                            Thread.Sleep(2000);
                        }
                        else { M1.Method1("Yenilemek isdediyiniz Id tapilmadi siyahidan sec !"); goto l5; }
                        Console.Clear();
                        goto l3;
                    case 4:
                        if (G2.Count == 0)
                        {
                            M1.Method1("Kitab yoxdur zehmet olmasa elave edin.");
                            goto case 1;
                        }
                        M1.Method8("Butun datalara nece saniye baxacaqsan ?");
                        int seconds = M1.ReadInt("Saniye secin:");
                        GetAllBook();
                        seconds = seconds * 1000;
                        Thread.Sleep((int)seconds);
                        Console.Clear();
                        goto l3;
                    case 5:
                        if (G2.Count == 0)
                        {
                            Thread.Sleep(3000);
                            Console.Clear();
                            goto case 1;
                        }
                        M1.Method3("<<<Diqqet siz her hansi bir melumati Id ile sile bilersiz !");
                        Console.WriteLine();
                        M1.Method8("Qeyd: Eger Id-ni unutmusuzsa buradan baxa bilersiz ! ID Cap edilsin<Enter>");
                        if (M1.Readbool())
                        {
                            GetAllBookId();
                        }
                    j5: index = M1.Method7("Silmek isdediyiniz datanin Id daxil edin:");
                        book = G2.GetId(index);
                        if (book != null)
                        {
                            M1.Method1("Silmek isdediyiniz Id-de asagidaki melumatlar var");
                            Console.WriteLine();
                            Console.WriteLine($"Kitabin Id:{book.Id}\nKitabin adi:{book.Name}\nSehve sayi::{book.PageGCount}\nQiymeti:{book.Price}\nJanri:{book.Genre}");
                            M1.Method3("Bu melumatlarin silinmesi ucun <Enter> duymesin sixin !");
                            if (M1.Readbool())
                            {
                                G2.Remove(book);
                                M1.Method4("Melumat ugurla silindi.");
                                goto l3;
                            }
                            else
                            {
                                M1.Method3("Silinme legv edildi !");
                                Thread.Sleep(2000);
                                Console.Clear();
                                goto l3;
                            }

                        }
                        else { M1.Method1("Silmek isdediyiniz Id tapilmadi !"); goto j5; }
                    case 6:
                        goto l6;
                }
            }
            else if (number == 3)
            {
                using (FileStream fs = File.OpenWrite(datafayll))
                {
                    Database db = new Database();
                    db.Author = G1;
                    db.Book = G2;
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, db);                   
                }
                M1.Method("Save edildi !");
                Thread.Sleep(2000);
                Console.Clear();
                goto h1;
            }
        }
        //Diger methodlar.
        static void GetAllAuthor()
        {
            Helper M1 = new Helper();
            foreach (var item in G1)
            {
                Console.WriteLine($"Id:{item.Id}\nAd:{item.Name}\nSoyad:{item.Surname}\n");
                Console.WriteLine("=======================");
            }
        }
        static void GetAllAuthorId()
        {
            foreach (var item in G1)
            {
                Console.WriteLine($"Id:{item.Id}");
            }
        }
        static void GetAllBook()
        {
            Helper M1 = new Helper();
            foreach (var item in G2)
            {
                Console.WriteLine($"AuthorId:{item.AuthorId}\nBookId:{item.Id}\nAd:{item.Name}\nSehve sayi:{item.PageGCount}\nQiymeti:{item.Price}\nJanri:{item.Genre}");
                Console.WriteLine("=======================");
            }
        }
        static void GetAllBookId()
        {
            foreach (var item in G2)
            {
                Console.WriteLine($"Book Id:{item.Id}");
            }
        }
        public static int CountA()
        {
            int digit = G1.Count;
            return digit;
        }
        public static int CountB()
        {
            int digts = G2.Count;
            return digts;
        }
        public static int RemoveIndex(int digits)
        {

            return digits;
        }
    }
}