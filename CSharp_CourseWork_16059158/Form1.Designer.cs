namespace CSharp_CourseWork_16059158
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.concordance = new System.Windows.Forms.Button();
            this.Read_File = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Display_Decreasing = new System.Windows.Forms.Button();
            this.Most_Common = new System.Windows.Forms.Button();
            this.Occur_More_Than = new System.Windows.Forms.Button();
            this.More_Than_TextBox = new System.Windows.Forms.RichTextBox();
            this.Number_Of_Words = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.collocation = new System.Windows.Forms.Button();
            this.collocationBox = new System.Windows.Forms.ListBox();
            this.Search_Box = new System.Windows.Forms.RichTextBox();
            this.Search = new System.Windows.Forms.Label();
            this.SearchDisplay = new System.Windows.Forms.ListBox();
            this.Display_info = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 308);
            this.listBox1.TabIndex = 0;
            // 
            // concordance
            // 
            this.concordance.Location = new System.Drawing.Point(13, 337);
            this.concordance.Name = "concordance";
            this.concordance.Size = new System.Drawing.Size(143, 36);
            this.concordance.TabIndex = 1;
            this.concordance.Text = "concordance";
            this.concordance.UseVisualStyleBackColor = true;
            this.concordance.Click += new System.EventHandler(this.concordance_Click);
            // 
            // Read_File
            // 
            this.Read_File.Location = new System.Drawing.Point(247, 12);
            this.Read_File.Name = "Read_File";
            this.Read_File.Size = new System.Drawing.Size(100, 30);
            this.Read_File.TabIndex = 2;
            this.Read_File.Text = "READ FILE";
            this.Read_File.UseVisualStyleBackColor = true;
            this.Read_File.Click += new System.EventHandler(this.Read_File_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(247, 63);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(100, 36);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(247, 116);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(100, 32);
            this.Remove.TabIndex = 4;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Display_Decreasing
            // 
            this.Display_Decreasing.Location = new System.Drawing.Point(247, 168);
            this.Display_Decreasing.Name = "Display_Decreasing";
            this.Display_Decreasing.Size = new System.Drawing.Size(177, 34);
            this.Display_Decreasing.TabIndex = 5;
            this.Display_Decreasing.Text = "Display/Decreasing";
            this.Display_Decreasing.UseVisualStyleBackColor = true;
            this.Display_Decreasing.Click += new System.EventHandler(this.Display_Decreasing_Click);
            // 
            // Most_Common
            // 
            this.Most_Common.Location = new System.Drawing.Point(247, 218);
            this.Most_Common.Name = "Most_Common";
            this.Most_Common.Size = new System.Drawing.Size(177, 33);
            this.Most_Common.TabIndex = 6;
            this.Most_Common.Text = "Most Common";
            this.Most_Common.UseVisualStyleBackColor = true;
            this.Most_Common.Click += new System.EventHandler(this.Most_Common_Click);
            // 
            // Occur_More_Than
            // 
            this.Occur_More_Than.Location = new System.Drawing.Point(247, 274);
            this.Occur_More_Than.Name = "Occur_More_Than";
            this.Occur_More_Than.Size = new System.Drawing.Size(177, 32);
            this.Occur_More_Than.TabIndex = 7;
            this.Occur_More_Than.Text = "Occur More Than";
            this.Occur_More_Than.UseVisualStyleBackColor = true;
            this.Occur_More_Than.Click += new System.EventHandler(this.Occur_More_Than_Click);
            // 
            // More_Than_TextBox
            // 
            this.More_Than_TextBox.Location = new System.Drawing.Point(457, 274);
            this.More_Than_TextBox.Name = "More_Than_TextBox";
            this.More_Than_TextBox.Size = new System.Drawing.Size(122, 32);
            this.More_Than_TextBox.TabIndex = 8;
            this.More_Than_TextBox.Text = "";
            // 
            // Number_Of_Words
            // 
            this.Number_Of_Words.FormattingEnabled = true;
            this.Number_Of_Words.ItemHeight = 16;
            this.Number_Of_Words.Location = new System.Drawing.Point(457, 12);
            this.Number_Of_Words.Name = "Number_Of_Words";
            this.Number_Of_Words.Size = new System.Drawing.Size(171, 36);
            this.Number_Of_Words.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number of Words";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(475, 350);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(153, 31);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // collocation
            // 
            this.collocation.Location = new System.Drawing.Point(475, 388);
            this.collocation.Name = "collocation";
            this.collocation.Size = new System.Drawing.Size(101, 36);
            this.collocation.TabIndex = 12;
            this.collocation.Text = "Collocation";
            this.collocation.UseVisualStyleBackColor = true;
            this.collocation.Click += new System.EventHandler(this.collocation_Click);
            // 
            // collocationBox
            // 
            this.collocationBox.FormattingEnabled = true;
            this.collocationBox.ItemHeight = 16;
            this.collocationBox.Location = new System.Drawing.Point(582, 388);
            this.collocationBox.Name = "collocationBox";
            this.collocationBox.Size = new System.Drawing.Size(46, 36);
            this.collocationBox.TabIndex = 13;
            // 
            // Search_Box
            // 
            this.Search_Box.Location = new System.Drawing.Point(687, 169);
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.Size = new System.Drawing.Size(136, 33);
            this.Search_Box.TabIndex = 14;
            this.Search_Box.Text = "";
            this.Search_Box.TextChanged += new System.EventHandler(this.Search_Box_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(718, 146);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(51, 17);
            this.Search.TabIndex = 15;
            this.Search.Text = "search";
            // 
            // SearchDisplay
            // 
            this.SearchDisplay.FormattingEnabled = true;
            this.SearchDisplay.ItemHeight = 16;
            this.SearchDisplay.Location = new System.Drawing.Point(875, 146);
            this.SearchDisplay.Name = "SearchDisplay";
            this.SearchDisplay.Size = new System.Drawing.Size(142, 132);
            this.SearchDisplay.TabIndex = 16;
            this.SearchDisplay.SelectedIndexChanged += new System.EventHandler(this.SearchDisplay_SelectedIndexChanged);
            // 
            // Display_info
            // 
            this.Display_info.Location = new System.Drawing.Point(875, 297);
            this.Display_info.Name = "Display_info";
            this.Display_info.Size = new System.Drawing.Size(142, 36);
            this.Display_info.TabIndex = 17;
            this.Display_info.Text = "Display Info";
            this.Display_info.UseVisualStyleBackColor = true;
            this.Display_info.Click += new System.EventHandler(this.Display_info_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(1, 528);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(10, 10);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "enter word to search, remove or edit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.Display_info);
            this.Controls.Add(this.SearchDisplay);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Search_Box);
            this.Controls.Add(this.collocationBox);
            this.Controls.Add(this.collocation);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number_Of_Words);
            this.Controls.Add(this.More_Than_TextBox);
            this.Controls.Add(this.Occur_More_Than);
            this.Controls.Add(this.Most_Common);
            this.Controls.Add(this.Display_Decreasing);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Read_File);
            this.Controls.Add(this.concordance);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button concordance;
        private System.Windows.Forms.Button Read_File;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Display_Decreasing;
        private System.Windows.Forms.Button Most_Common;
        private System.Windows.Forms.Button Occur_More_Than;
        private System.Windows.Forms.ListBox Number_Of_Words;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button collocation;
        private System.Windows.Forms.ListBox collocationBox;
        private System.Windows.Forms.RichTextBox Search_Box;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.ListBox SearchDisplay;
        private System.Windows.Forms.RichTextBox richTextBox2;
        public System.Windows.Forms.Button Display_info;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.RichTextBox More_Than_TextBox;
        private System.Windows.Forms.Label label2;
    }
}

