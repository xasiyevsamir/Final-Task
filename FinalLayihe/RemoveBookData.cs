using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLayihe
{
    [Serializable]
    public class RemoveBookData: IEquatable<RemoveBookData>, IdInterface
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public Genre Genre { get; set; }
        public int PageGCount { get; set; }
        public decimal Price { get; set; }
        public bool Equals(RemoveBookData? other)
        {
            if (other == null) return false;

            return this.Id == other.Id;
        }
    }
}
