using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_CourseWork_16059158
{
    public partial class Form1 : Form
    {
        private AVLTree<Word> myAVLTree = new AVLTree<Word>();
        private Node<Word> NodeToSend;
        private List<Word> listOfWord;
        public Form1()
        {
            InitializeComponent();
        }

        public Node<Word> SendNODE
        {
            get { return this.NodeToSend; }
            set { this.NodeToSend = value; }
        }

        public AVLTree<Word> SendTree
        {
            get { return this.myAVLTree; }
            set { this.myAVLTree = value; }
        }


        private int collocationMethod(String data, String data2, AVLTree<Word> tree)
        {
            int result = 0;
            Word word1 = new Word(data);
            Word word2 = new Word(data2);

            Node<Word> node1 = findNode(word1, tree.ROOT);//find node from string 1
            Node<Word> node2 = findNode(word2, tree.ROOT); //find node from string 2
            foreach (Location loc in node1.Data.LOCATIONS)
            {

                foreach (Location loca in node2.Data.LOCATIONS)
                {
                    if ((loc.LineNUMBER.CompareTo(loca.LineNUMBER) == 0) && (loca.POSITION == loc.POSITION + 1))
                        result += 1;
                }
                listBox1.Items.Add("--------------------------------------------------------");
            }


            return result;
        }

        private List<String> cleanUserinput()//give back user input without without unwanted chars
        {
            listBox1.Items.Clear();
            String userInput = Search_Box.Text;
            string[] word = userInput.Split(' ', ',', '.', '?', ';');
            String[] seperator = new string[5];

            List<String> finalWord = new List<String>();
            foreach (String w in word)
            {
                if (w != "")
                {
                    listBox1.Items.Add(" cleaned input, your word is: " + w);
                    finalWord.Add(w);
                }

            }
            listBox1.Items.Add("\n");
            return finalWord;
        }


        private List<String> cleanUserinput2()//give back user input without without unwanted chars
        {
            listBox1.Items.Clear();
            String userInput = richTextBox1.Text;
            string[] word = userInput.Split(' ', ',', '.', '?', ';');
            String[] seperator = new string[5];

            List<String> finalWord = new List<String>();
            foreach (String w in word)
            {
                if (w != "")
                {
                    listBox1.Items.Add(" cleaned input, your word is: " + w);
                    finalWord.Add(w);
                }

            }
            listBox1.Items.Add("\n");
            return finalWord;
        }


        private void displayWords(Node<Word> root)
        {
            if (root != null)
            {
                displayWords(root.Left);
                listBox1.Items.Add(root.Data.WORD);
                listBox1.Items.Add("Word location count :" + root.Data.LOCATIONS.Count);
                listBox1.Items.Add("\n");
                displayWords(root.Right);
            }
        }

        private List<Word> displayDecreasing(Node<Word> root, ref List<Word> list)//display list of word decreasing order
        {
            List<Word> res = new List<Word>();
            if (root != null)
            {
                list.Add(root.Data);
                res = list;
                //travers the tree
                displayDecreasing(root.Right, ref list);
                displayDecreasing(root.Left, ref list);
            }

            return res.OrderByDescending(x => x.LOCATIONS.Count).ToList();
        }


        private void SearchDisplayer(Node<Word> root, String Word)//display list of word decreasing order
        {
            List<Word> res = new List<Word>();
            if (root != null)
            {
                int index = 0;
                int endIndex = 0;
                //travers the tree
                SearchDisplayer(root.Right, Word);
                index = root.Data.WORD.ToLower().IndexOf(Word.ToLower());
                endIndex = Word.Length;
                if ((index >= 0) && (endIndex < root.Data.WORD.Length) && root.Data.WORD.ToLower().Substring(0, endIndex).Equals(Word.ToLower()))
                {
                    SearchDisplay.Items.Add(root.Data.WORD);
                }
                SearchDisplayer(root.Left, Word);
            }

        }

        private Node<Word> findNode(Word item, Node<Word> node)//find node from input string
        {
            Node<Word> result = null;
            if (node != null)
            {

                if (item.WORD.ToLower().CompareTo(node.Data.WORD.ToLower()) < 0)
                {
                    return findNode(item, node.Left);
                }
                else if (item.WORD.ToLower().CompareTo(node.Data.WORD.ToLower()) > 0)
                {
                    return findNode(item, node.Right);
                }
                else if (item.WORD.ToLower().Equals(node.Data.WORD.ToLower()))
                {
                    result = node;
                }
            }
            return result;
        }

        /**
         * BUTTONS START HERE!  
         * 
         */


        private void Read_File_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//clear listBox

            if (myAVLTree.ROOT != null)
                myAVLTree = new AVLTree<Word>(); //reset whole tree in case button was already pressed before

            const int MAX_FILE_LINES = 50000;
            string[] AllLines = new string[MAX_FILE_LINES];
            // set the path where the file to be read is saved
            string path = @"C:\Users\adamb\source\repos\CSharp_CourseWork_16059158\myText.txt";
            AllLines = File.ReadAllLines(path);
            int lineNumber = 0;
            foreach (string line in AllLines)
            {
                lineNumber++;//line number only add at every new line
                int wordPos = 1;//re-initialise word position every new line
                Word myWord;
                Location wordLocation;
                Node<Word> myData;

                string[] words = line.Split(' ', ',', '.', '?', ';');
                words = words.Where(val => val != "").ToArray();

                foreach (String word in words)
                {
                    listBox1.Items.Add(word);
                    if (word != "")
                    {
                        myWord = new Word(word);
                        myData = findNode(myWord, myAVLTree.ROOT);//fetch node from which i can reatreave DATA Word 

                        if (myData == null) //if avl does not already contains Word obj than add it
                        {
                            wordLocation = new Location(wordPos, lineNumber);//create a new location for the word
                            myWord.addEdge(wordLocation);//add a new link of position for the word
                            myAVLTree.InsertItem(myWord);//insert data in avl 
                            wordPos++;//position of the word + 1 for each word
                        }
                        else //avl contains the data already 
                        {
                            wordLocation = new Location(wordPos, lineNumber);
                            myData.Data.addEdge(wordLocation);
                            wordPos++;//position of the word + 1 for each word
                        }
                    }
                }

            }
            Info info = new Info();
            SendTree = myAVLTree;//create tree
            info.RECEIVED_TREE = SendTree;//send tree to info class
            listBox1.Items.Add(" YOUR TEXT FILE was LOADED..... ");
            int uniqueWordCount = myAVLTree.Count();
            Number_Of_Words.Items.Clear();
            Number_Of_Words.Items.Add(uniqueWordCount);
        }

        private void Display_Decreasing_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//clear listBox
            List<Word> refListWord = new List<Word>();
            List<Word> finalListWord = new List<Word>();
            finalListWord = displayDecreasing(myAVLTree.ROOT, ref refListWord);

            foreach (Word w in finalListWord)
            {
                listBox1.Items.Add(w.WORD);
                listBox1.Items.Add("occurence of Word : " + w.LOCATIONS.Count);
                listBox1.Items.Add("\n");
            }


        }

        private void Display_info_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            Word Word = new Word("");
            Node<Word> myData = null;
            if (SearchDisplay.SelectedItem != null)
            {
                Word = new Word(SearchDisplay.SelectedItem.ToString());
                myData = findNode(Word, myAVLTree.ROOT);//fetch node from which i can reatreave DATA Word 
            }

            else
            {
                foreach (String s in cleanUserinput())
                {
                    Word = new Word(s);
                    break;
                }
                myData = findNode(Word, myAVLTree.ROOT);//fetch node from which i can reatreave DATA Word 
            }
            if (myData != null)
            {
                //info.InfoWord_Text = myData.Data.WORD;
                int count = myData.Data.LOCATIONS.Count();
                info.word_text.Text = myData.Data.WORD;
                info.occurences_text.Text = Convert.ToString(count);
                String line = "";
                String position = "";
                foreach(Location line_position in myData.Data.LOCATIONS)
                {
                    if(line_position.LineNUMBER != 0)
                    line += Convert.ToString(line_position.LineNUMBER) + ",";
                    if(line_position.POSITION != 0)
                    position += Convert.ToString(line_position.POSITION) + ",";

                }
                info.line_text.Text = line;
                info.positions_text.Text = position;

                SendNODE = myData; //create node to send 
                info.USE_RECEIVED_NODE = SendNODE;//transfer node to info form class
                info.RECEIVED_TREE = SendTree;//send tree to info class
                info.save.Visible = false;
            }

            else
            {
                SendNODE = myData; //create node to send 
                info.USE_RECEIVED_NODE = SendNODE;//transfer node to info form class
                info.RECEIVED_TREE = SendTree;//send tree to info class
            }
            info.Show(); 

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            //SearchDisplay.Items.Clear();
            Word Word = new Word("");
            Info info = new Info();
            Node<Word> myData = null;
            label1.Text = myAVLTree.ROOT.Data.WORD;


            if (listBox1.SelectedItem != null)
            {
                Word = new Word(listBox1.SelectedItem.ToString());
                myData = findNode(Word, myAVLTree.ROOT);//fetch node from which i can reatreave DATA Word 
            }
            else
            {
                foreach (String s in cleanUserinput())
                {
                    Word = new Word(s);
                    break;
                }
                myData = findNode(Word, myAVLTree.ROOT);//fetch node from which i can reatreave DATA Word 
            }

            if (myData != null)
            {
                //info.InfoWord_Text = myData.Data.WORD;
                int count = myData.Data.LOCATIONS.Count();
                info.word_text.Text = myData.Data.WORD;
                info.occurences_text.Text = Convert.ToString(count);
                String line = "";
                String position = "";
                foreach (Location line_position in myData.Data.LOCATIONS)
                {
                    if(line_position.LineNUMBER != 0)
                       line += Convert.ToString(line_position.LineNUMBER) + ",";
                    if(line_position.POSITION != 0)
                       position += Convert.ToString(line_position.POSITION) + ",";
                }
                info.line_text.Text = line;
                info.positions_text.Text = position;

                SendNODE = myData; //create node to send 
                info.USE_RECEIVED_NODE = SendNODE;//transfer node to info form class
                info.RECEIVED_TREE = SendTree;//send tree to info class
            }

            else
            {
                SendNODE = myData; //create node to send 
                info.USE_RECEIVED_NODE = SendNODE;//transfer node to info form class
                info.RECEIVED_TREE = SendTree;//send tree to info class
            }
            info.Show();

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();//clear listBox
            Word Word = new Word("");
            Node<Word> nodeWord = null;
            String toDelete; 
            if (listBox1.SelectedItem != null)
            {
                toDelete = listBox1.SelectedItem.ToString();
                Word = new Word(listBox1.SelectedItem.ToString());
                nodeWord = findNode(Word, myAVLTree.ROOT);//fetch node from which i can reatreave DATA Word 
            }

            else
            {
                foreach (String s in cleanUserinput())
                {
                    Word = new Word(s);
                    break;
                }
                toDelete = Word.WORD;
                nodeWord = findNode(Word, myAVLTree.ROOT);//fetch node from which i can reatreave DATA Word 
            }

            if (nodeWord != null)
            {
                MessageBox.Show("Removed Word: "  + nodeWord.Data.WORD);
                //listBox1.Items.Add(" Removed Word:  " + nodeWord.Data.WORD + " with occurences " + nodeWord.Data.LOCATIONS.Count);
                myAVLTree.removeItemAVLT(nodeWord.Data);
                listBox1.Items.Remove(toDelete);
                Number_Of_Words.Items.Clear();
                Number_Of_Words.Items.Add(myAVLTree.Count());
            }
            else
            {
                MessageBox.Show("Sorry :/ the word: " + Word.WORD.ToLower() + " does not exist in the tree");
            }
        }

        private void Occur_More_Than_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//clear listBox
            try 
            {
                String amount = More_Than_TextBox.Text;
                int x = Int32.Parse(amount);

                List<Word> refListWord = new List<Word>();
                List<Word> finalListWord = new List<Word>();
                finalListWord = displayDecreasing(myAVLTree.ROOT, ref refListWord);
                finalListWord.OrderByDescending(obj => obj.LOCATIONS.Count);
                foreach (Word word in finalListWord)
                {
                    if (x < word.LOCATIONS.Count)
                    {
                        listBox1.Items.Add(word.WORD);
                        listBox1.Items.Add("occurences : " + word.LOCATIONS.Count);
                        listBox1.Items.Add("\n");
                    }
                }
            }
            catch
            {
                listBox1.Items.Add("enter number in valid format");
            }


        }

        private void concordance_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            displayWords(myAVLTree.ROOT);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Most_Common_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//clear listBox
            List<Word> refListWord = new List<Word>();
            List<Word> finalListWord = new List<Word>();
            finalListWord = displayDecreasing(myAVLTree.ROOT, ref refListWord);


            foreach (Word w in finalListWord)
            {
                listBox1.Items.Add("The most common word is : " + w.WORD);
                listBox1.Items.Add("occurence of the Word : " + w.LOCATIONS.Count);
                break;//break to only display the first one
            }
        }

        private void Search_Box_TextChanged(object sender, EventArgs e)
        {
            SearchDisplay.Items.Clear();
            //listBox1.Items.Clear();
            SearchDisplay.Items.Add(Search_Box.Text);
            SearchDisplayer(myAVLTree.ROOT, Search_Box.Text);
        }

        private void collocation_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//clear listBox
            collocationBox.Items.Clear();
            Word Word = new Word("");
            System.Console.WriteLine(Word.OCCURENCES);
            int countBreaker = 0;
            String[] myWords = new string[2];
            int wordCount = 0;
            List<String> cleaninput = new List<string>();
            cleaninput = cleanUserinput2();
            foreach (String s in cleaninput)
            {
                myWords[wordCount] = s;
                wordCount++;
                //listBox1.Items.Add(" >>>>>////" + s);
                countBreaker++;
            }


            Node<Word> nodeWord = null;
            Node<Word> nodeWord2 = null;
            if (cleaninput.Count() == 2)
            {
                if (myWords[0] != "")
                    nodeWord = findNode(new Word(myWords[0]), myAVLTree.ROOT);
                if (myWords[1] != "")
                    nodeWord2 = findNode(new Word(myWords[1]), myAVLTree.ROOT);
                if (nodeWord != null && nodeWord2 != null && myWords[0] != " " && myWords[1] != " ")
                {
                    int collocation = collocationMethod(nodeWord.Data.WORD, nodeWord2.Data.WORD, myAVLTree);
                    listBox1.Items.Add(" The Words : " + nodeWord.Data.WORD + " and " + nodeWord2.Data.WORD);
                    listBox1.Items.Add(" appear next to each other ");
                    listBox1.Items.Add(collocation + " times ");
                    collocationBox.Items.Add(collocation);
                }
            }
            else
            {
                listBox1.Items.Add(" Sorry :/ please enter two words \n that exist in the tree to proceed with data analysis ");
            }
        }

        private void SearchDisplay_SelectedIndexChanged(object sender, EventArgs e)
        { 
            
        }
    }
}
