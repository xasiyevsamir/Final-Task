﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLayihe
{
    [Serializable]
    public class AuthorClass:IEquatable<AuthorClass>,IdInterface
    {
        public AuthorClass()
        {
            int counter = Program.CountA();          
            counter++;
            this.Id = counter;
        }
        public int Id { get; private set; }
        public string Name { get ; set; }
        public string Surname { get; set; }

        public bool Equals(AuthorClass? other)
        {
           if ( other==null) return false;

            return this.Id == other.Id;
        }
    }
}
