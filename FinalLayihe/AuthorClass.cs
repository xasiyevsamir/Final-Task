using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLayihe
{
    internal class AuthorClass:IEquatable<AuthorClass>,IdInterface
    {  
        static int counter=0;
        public AuthorClass()
        {
            counter++;
            this.Id=counter;
        }
        public int Id { get; private set; }
        public string Name { get ; set; }
        public string Surname { get; set; }

        public bool Equals(AuthorClass? other)
        {
           if ( other==null) return false;

            return this.Id == other.Id;
        }

        public override string ToString()
        {
            return $"Id: {Id}\n Ad: {Name}\n Soyad: {Surname}";
        }
    }
}
