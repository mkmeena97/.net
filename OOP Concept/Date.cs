using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concept
{
    internal class Date
    {
        public int dd { get; set; }
        public int mm { get; set; }
        public int yy { get; set; }

        public Date()
        {
        }

        public Date(int dd, int mm, int yy)
        {
            this.dd = dd;
            this.mm = mm;
            this.yy = yy;
        }

        public void ShowDate(int dd, int mm, int yy)
        {
            Console.WriteLine(dd + "-" + mm + "-" + yy);
        }
    }
}
