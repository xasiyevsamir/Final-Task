using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLayihe
{
    [Serializable]
    public class BooKClass:IEquatable<BooKClass>, IdInterface
    {
        public BooKClass()
        {
            int counter = Program.CountB();
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
    }
}
