using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLayihe
{
    [Serializable]
    public  class GenericStore<T> : IEnumerable<T> where T : class, IEquatable<T>,IdInterface
    {
        static Helper H = new Helper();
        T[] data=new T[0];
        public void Add(T item)
        {
            int len = data.Length;
            Array.Resize(ref data, len+1);
            data[len] = item;
        }
        public void Remove(T item)
        {  int index=Array.IndexOf(data, item);
            if(index !=-1)
            {
                for (int i = index; i < data.Length-1; i++)
                {
                    data[i] = data[i + 1];
                }
                Array.Resize(ref data, data.Length -1);
            }
        }
        public T GetId(int id)
        {
            var data1 = Array.Find(data, item=>item.Id==id);                
                return data1;                        
        }
        public bool GetBoolId(int number)
        {            
            if (Array.Exists(data, item => item.Id == number))
            {
                return true;
            } 
            return false;
        }
        public int Count { get { return data.Length; } set { } }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in data)
            {
               yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
