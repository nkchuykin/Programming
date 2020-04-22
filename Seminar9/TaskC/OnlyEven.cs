using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OnlyEven : IEnumerable<int>
{
    List<int> list;
    public OnlyEven(List<int> list)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<int> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

