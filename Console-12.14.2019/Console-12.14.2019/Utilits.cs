using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_12._14._2019
{
    static class  Utilits
    {
        public static bool  Reqemdirmi(string inp)
        {
            try
            {
                Convert.ToInt32(inp);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
