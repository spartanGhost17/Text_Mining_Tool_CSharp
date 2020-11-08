namespace CSharp_CourseWork_16059158
{
    partial class Info
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
            this.Info_Word = new System.Windows.Forms.ListBox();
            this.Info_Occurences = new System.Windows.Forms.ListBox();
            this.Info_Line = new System.Windows.Forms.ListBox();
            this.Info_Positions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.positions = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.word_text = new System.Windows.Forms.TextBox();
            this.occurences_text = new System.Windows.Forms.TextBox();
            this.line_text = new System.Windows.Forms.TextBox();
            this.positions_text = new System.Windows.Forms.TextBox();
            this.testXX = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Info_Word
            // 
            this.Info_Word.FormattingEnabled = true;
            this.Info_Word.ItemHeight = 16;
            this.Info_Word.Location = new System.Drawing.Point(1, 342);
            this.Info_Word.Name = "Info_Word";
            this.Info_Word.Size = new System.Drawing.Size(10, 4);
            this.Info_Word.TabIndex = 0;
            this.Info_Word.SelectedIndexChanged += new System.EventHandler(this.Info_Word_SelectedIndexChanged);
            // 
            // Info_Occurences
            // 
            this.Info_Occurences.FormattingEnabled = true;
            this.Info_Occurences.ItemHeight = 16;
            this.Info_Occurences.Location = new System.Drawing.Point(1, 342);
            this.Info_Occurences.Name = "Info_Occurences";
            this.Info_Occurences.Size = new System.Drawing.Size(10, 4);
            this.Info_Occurences.TabIndex = 1;
            this.Info_Occurences.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Info_Line
            // 
            this.Info_Line.FormattingEnabled = true;
            this.Info_Line.ItemHeight = 16;
            this.Info_Line.Location = new System.Drawing.Point(1, 342);
            this.Info_Line.Name = "Info_Line";
            this.Info_Line.Size = new System.Drawing.Size(10, 4);
            this.Info_Line.TabIndex = 2;
            // 
            // Info_Positions
            // 
            this.Info_Positions.FormattingEnabled = true;
            this.Info_Positions.ItemHeight = 16;
            this.Info_Positions.Location = new System.Drawing.Point(1, 342);
            this.Info_Positions.Name = "Info_Positions";
            this.Info_Positions.Size = new System.Drawing.Size(10, 4);
            this.Info_Positions.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Occurences";
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(331, 172);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(30, 17);
            this.line.TabIndex = 6;
            this.line.Text = "line";
            // 
            // positions
            // 
            this.positions.AutoSize = true;
            this.positions.Location = new System.Drawing.Point(331, 253);
            this.positions.Name = "positions";
            this.positions.Size = new System.Drawing.Size(64, 17);
            this.positions.TabIndex = 7;
            this.positions.Text = "positions";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(241, 311);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 8;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // word_text
            // 
            this.word_text.Location = new System.Drawing.Point(69, 41);
            this.word_text.Name = "word_text";
            this.word_text.Size = new System.Drawing.Size(219, 22);
            this.word_text.TabIndex = 9;
            // 
            // occurences_text
            // 
            this.occurences_text.Location = new System.Drawing.Point(69, 103);
            this.occurences_text.Name = "occurences_text";
            this.occurences_text.Size = new System.Drawing.Size(219, 22);
            this.occurences_text.TabIndex = 10;
            // 
            // line_text
            // 
            this.line_text.Location = new System.Drawing.Point(69, 172);
            this.line_text.Name = "line_text";
            this.line_text.Size = new System.Drawing.Size(219, 22);
            this.line_text.TabIndex = 11;
            // 
            // positions_text
            // 
            this.positions_text.Location = new System.Drawing.Point(69, 247);
            this.positions_text.Name = "positions_text";
            this.positions_text.Size = new System.Drawing.Size(219, 22);
            this.positions_text.TabIndex = 12;
            // 
            // testXX
            // 
            this.testXX.FormattingEnabled = true;
            this.testXX.ItemHeight = 16;
            this.testXX.Location = new System.Drawing.Point(562, 342);
            this.testXX.Name = "testXX";
            this.testXX.Size = new System.Drawing.Size(10, 4);
            this.testXX.TabIndex = 13;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 346);
            this.Controls.Add(this.testXX);
            this.Controls.Add(this.positions_text);
            this.Controls.Add(this.line_text);
            this.Controls.Add(this.occurences_text);
            this.Controls.Add(this.word_text);
            this.Controls.Add(this.save);
            this.Controls.Add(this.positions);
            this.Controls.Add(this.line);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Info_Positions);
            this.Controls.Add(this.Info_Line);
            this.Controls.Add(this.Info_Occurences);
            this.Controls.Add(this.Info_Word);
            this.Name = "Info";
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Info_Word;
        private System.Windows.Forms.ListBox Info_Occurences;
        private System.Windows.Forms.ListBox Info_Line;
        private System.Windows.Forms.ListBox Info_Positions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label positions;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.TextBox word_text;
        public System.Windows.Forms.TextBox occurences_text;
        public System.Windows.Forms.TextBox line_text;
        public System.Windows.Forms.TextBox positions_text;
        public System.Windows.Forms.ListBox testXX;
    }
}