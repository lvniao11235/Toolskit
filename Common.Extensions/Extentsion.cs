using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Common.Extensions
{
    public static class Extentsion
    {
        public static String ToJson(this Object obj)
        {
            return  JsonConvert.SerializeObject(obj);
        }
    }
}
