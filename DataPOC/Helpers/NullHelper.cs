using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPOC.Helpers
{
    public class NullHelper
    {
        public static string ValueFromDB<T>(T obj)
        {

            //return (obj == null || DBNull.Value.Equals(obj)) ? default(T) : (T) obj;

            //return (obj is string) ? obj.ToString() : null;

            //return (obj is string || obj is int) ? obj.ToString() : "Null";

            return (obj == null || DBNull.Value.Equals(obj)) ? "Null" : obj.ToString();
        }
    }
}
