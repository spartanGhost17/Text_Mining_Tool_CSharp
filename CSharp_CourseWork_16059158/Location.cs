using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CourseWork_16059158
{
    public class Location
    {
        private int position;
        private int lineNumber;

        public Location(int position, int lineNumber)
        {
            POSITION = position;
            LineNUMBER = lineNumber;
        }

        public int POSITION
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public int LineNUMBER
        {
            get { return this.lineNumber; }
            set { this.lineNumber = value; }
        }
    }

}
