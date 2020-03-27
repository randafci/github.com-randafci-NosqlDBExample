using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoSqlDataBaseExample.BDSetting
{
    public interface Isetting <T> where T : class
    {
       T Add(T item, string Name);
        List<T> GetAll(string Name);
    }
}
