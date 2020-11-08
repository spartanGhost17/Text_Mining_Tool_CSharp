using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_CourseWork_16059158
{
    public partial class Info : Form
    {
        private String Word_Info;
        private String occurences_Info;
        private LinkedList<Location> locations;
        private Node<Word> receivedNode;
        private AVLTree<Word> AVLTree;

        public Info()
        {
            InitializeComponent();

        }

        public String InfoWord_Text
        {
            get { return Word_Info; }
            set { this.Word_Info = value; }
        }
        public String occurences_Text
        {
            get { return occurences_Info; }
            set { this.occurences_Info = value; }
        }

        public LinkedList<Location> LOCATIONS
        {
            get { return this.locations; }
            set { this.locations = value; }
        }
        public Node<Word> USE_RECEIVED_NODE
        {
            get { return this.receivedNode; }
            set { this.receivedNode = value; }
        }

        public AVLTree<Word> RECEIVED_TREE
        {
            get { return this.AVLTree; }
            set { this.AVLTree = value; }
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Info_Word_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();

            String word = word_text.Text;
            int occ = int.Parse(occurences_text.Text);
            RECEIVED_TREE.removeItemAVLT(USE_RECEIVED_NODE.Data);

            Word newWord = new Word(word);
            String[] lines = line_text.Text.Split(',');
            lines = lines.Where(val => val != "").ToArray();
            String[] positions = positions_text.Text.Split(',');
            positions = positions.Where(val => val != "").ToArray();

            bool keepData_Source  = ((occ - lines.Length)==0) && ((occ - positions.Length) == 0);//if zero we don't need to add more links, just overWrite existing info
            int linePos = lines.Length - positions.Length;
            testXX.Items.Add(USE_RECEIVED_NODE.Data.LOCATIONS.Count() - lines.Length);

            /**
             * check if we have to keep the source data intact or not
             * 
             */

            if (keepData_Source)////
            {
                int v = 0;//counter
                foreach (Location lc in newWord.LOCATIONS)
                {
                    if(v < lines.Length)
                       lc.LineNUMBER = int.Parse(lines[v]);
                    if(v < positions.Length)
                    lc.POSITION = int.Parse(positions[v]);
                    v++;
                }
                v = 0;//reset 
            }
            else ///data has been changed
            {
                newWord.LOCATIONS.Clear();//clear list
                bool positionAddedInfo = false;
                bool lineAddedInfo = false;
                bool same_size = false;
                string[] myArray;
                if (lines.Length < positions.Length)
                {
                    myArray = positions;
                    positionAddedInfo = true;
                }     
                else if (lines.Length > positions.Length)
                {
                    myArray = lines;
                    lineAddedInfo = true;
                }
                else
                {
                    myArray = lines;
                    same_size = true;
                }

                for (int i = 0; i < myArray.Length; i++)
                {
                    if(positionAddedInfo)
                    {
                        Location loc = new Location(int.Parse(myArray[i]), 0);
                        newWord.addEdge(loc);
                    }
                    else if (lineAddedInfo)
                    {
                        Location loc = new Location(0, int.Parse(myArray[i]));
                        newWord.addEdge(loc);
                    }
                    else
                    {
                        Location loc = new Location(int.Parse(positions[i]), int.Parse(myArray[i]));
                        newWord.addEdge(loc);
                    }
                }

                if(positionAddedInfo)
                {
                    int v = 0;
                    foreach(Location loca in newWord.LOCATIONS)
                    {
                        if (v >= lines.Length)
                            break;
                        if (v < lines.Length )
                        {
                          loca.LineNUMBER = int.Parse(lines[v]) ;
                        }
                        v++;
                    }
                    v = 0;
                }

                if (lineAddedInfo)
                {
                    int v = 0;
                    foreach (Location loca in newWord.LOCATIONS)
                    {
                        if (v >= positions.Length)
                            break;
                        if (v < positions.Length)
                        {
                            loca.POSITION = int.Parse(positions[v]);
                        }
                        v++;
                    }
                    v = 0;
                }
                if (newWord.LOCATIONS.Count() < occ)
                {
                    int condition = Math.Abs(newWord.LOCATIONS.Count() - occ);
                    for (int i = 0; i < condition; i++)
                    {
                        Location loc = new Location(0, 0);
                        newWord.addEdge(loc);
                    }
                }

            }

            RECEIVED_TREE.InsertItem(newWord);
            form1.SendTree = RECEIVED_TREE;
            
            
            //form1.listBox1.Items.Clear();
            //form1.listBox1.Items.Add(" >>>"+ InfoWord_Text);
            //form1.More_Than_TextBox.Text = InfoWord_Text;
            this.Close();
        }
    }
}
