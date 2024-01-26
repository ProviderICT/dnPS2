using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2Q2
{
    interface Icrud<T>
    {
        void Create(T data);
        T Read(int id);
        void Update(int id,T UData);
        void Delete(int id);
    }
}
