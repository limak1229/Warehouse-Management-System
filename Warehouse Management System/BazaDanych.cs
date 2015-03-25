using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management_System
{
    class BazaDanych
    {
        private static bazaDCDataContext DT = new bazaDCDataContext();
        private BazaDanych()
        {
        }
        public static bazaDCDataContext Polaczenie
        {
            get { return DT; }
        }
    }

}
