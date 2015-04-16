using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
   public interface IDataStore
    {
       void AddData(string key, object data);

       void RemovData(string key);

       object FindData(string key);

       void UpdateData(string key, object data);
 
    }
}
