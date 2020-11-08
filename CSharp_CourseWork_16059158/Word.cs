using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CourseWork_16059158
{
    public class Word : IComparable
    {
        private String word;
        private int occurences;
        private LinkedList<Location> locations;

        public Word(String item)
        {
            this.word = item;
            this.locations = new LinkedList<Location>();
            this.occurences = this.locations.Count();
        }

        public void addEdge(Location to)
        {
            this.locations.AddLast(to);
        }

        public String WORD
        {
            get { return this.word; }
            set { this.word = value; }
        }

        public int OCCURENCES
        {
            get { return this.occurences; }
            set { this.occurences = value; }
        }

        public LinkedList<Location> LOCATIONS
        {
            get { return this.locations; }
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Word other = obj as Word;
            if (obj != null) return this.WORD.ToLower().CompareTo(other.WORD.ToLower());
            else
                throw new NotImplementedException(" Cannot compare these objects ");
        }

    }

}
