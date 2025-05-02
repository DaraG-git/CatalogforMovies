using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDB<T, U>
    {
        void Create(T item);
        T Read(U key);
        IEnumerable<T> ReadAll();
        void Update (T item);
        void Delete(U key);
    }
}
