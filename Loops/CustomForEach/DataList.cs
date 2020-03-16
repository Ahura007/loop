using System.Collections;
using System.Collections.Generic;

namespace Loops.CustomForEach
{
    public class CustomEnumerator : IEnumerator, IEnumerable
    {
        private List<Person> datalist;
        int position = -1;

     
        public CustomEnumerator()
        {
            datalist = new List<Person>()
            {
                new Person("1","1"),
                new Person("2","2"),
                new Person("3","3"),
                new Person("4","4"),
                new Person("5","5"),
                new Person("6","6"),
                new Person("7","7"),
                new Person("8","8"),
                new Person("8","9"),
            };
        }

        
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

 
        public bool MoveNext()
        {
            position++;
            return (position < datalist.Count);
        }

  
        public void Reset()
        {
            position = 0;
        }

  
        public object Current
        {
            get { return datalist[position]; }
        }
    }
}