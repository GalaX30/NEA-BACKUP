using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA
{
    class PublicVariables
    {
        public static bool _permission = false;

        public static bool Permission
        {
            get { return _permission; }
            set { _permission = value; }
        }
    }
}
