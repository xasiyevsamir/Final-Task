using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLayihe
{
    [Serializable]
    public class Database
    {
        public GenericStore<AuthorClass> Author { get; set; }
        public GenericStore<BooKClass> Book { get; set; }
        public  GenericStore<RemoveAuthorData> Remove { get; set; }
        public  GenericStore<RemoveBookData> Remove1 { get; set; }
        
    }
}
