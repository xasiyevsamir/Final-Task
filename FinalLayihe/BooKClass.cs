using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLayihe
{
    internal class BooKClass:IEquatable<BooKClass>, IdInterface
    {
        static int counter = 0;
        public BooKClass()
        {
            counter++;
            this.Id = counter;
        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public  Genre Genre { get; set; }
        public int PageGCount { get; set; }
        public decimal Price { get; set; }

        public bool Equals(BooKClass? other)
        {
            if (other == null) return false;

            return this.Id == other.Id;
        }

        public override string ToString()
        {
            return $"Id: {Id}\n Ad: {Name}\n Genre: {Genre}\n Sehve sayi:{PageGCount}\n Qiymeti: {Price}";
        }
    }
}
