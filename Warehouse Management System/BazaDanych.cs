using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management_System
{
    class BazaDanych
    {
        private static BazaDataClassesDataContext DT = new BazaDataClassesDataContext();
        private BazaDanych()
        {
        }
        public static BazaDataClassesDataContext Polaczenie
        {
            get { return DT; }
        }
    }

}
