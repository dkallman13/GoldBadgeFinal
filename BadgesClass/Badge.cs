using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesClass
{
    public class Badge
    {
        public List<string> DoorAccess { get; set; }
        public int ID { get; }
        public Badge(int id)
        {
            ID = id;
        }
        public Badge(int id, List<string> doors)
        {
            ID = id;
            DoorAccess = doors;
        }
    }
}
