using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH
{
    class Transporter
    {
        static private object box;
        public static object BOX
        {
            get { return box; }
            set { box = value; }
        }
        public static void Boxing(object _box) { BOX = _box; }
        public static object GetBox() { return BOX; }
    }
}
