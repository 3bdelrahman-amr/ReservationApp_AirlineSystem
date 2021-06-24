using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Validate
    {

        public bool isinteger(string s, ref int result)
        {
            if (s == "" || int.TryParse(s, out result))
                return false;


            return true;
        }



    }
}
