using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL_Abstract
{

    public interface IDAL<T>
    {
        bool Add(T data);
        bool Remove(T data);
        bool Edit(T data);

        IEnumerable<T> GetAll();
        T Get();
    }
}
