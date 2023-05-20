using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLayihe
{
    [Serializable]
    public  class RemoveAuthorData:IEquatable<RemoveAuthorData>,IdInterface
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Equals(RemoveAuthorData? other)
        {
            if (other == null) return false;

            return this.Id == other.Id;
        }
    }
}
