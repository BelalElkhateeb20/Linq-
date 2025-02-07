using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int32Extension
{
    public static class IntExtension
    {
        /// Extension Method
        public static int Mirror(this int i)
        {
            var Arr = i.ToString().ToCharArray();

            Array.Reverse(Arr);

            return int.Parse(new string(Arr));
        }

    }
}
