using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something
{
    class MyList : IEnumerable<int>, IEnumerator<int>
    {
        public int Current { get; private set; }

        public MyList()
        {
            Current = 100;
        }
        public IEnumerator<int> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool MoveNext()
        {
            Current += 100;
            return Current < 1000;
        }

        public void Reset()
        {
            Current = 100;
        }


        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
