namespace WordCountAppNB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            button5 = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 33);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Load a file";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(541, 33);
            label2.Name = "label2";
            label2.Size = new Size(195, 15);
            label2.TabIndex = 1;
            label2.Text = "Choose the frequency of each word";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(297, 33);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 2;
            label3.Text = "Split the files into word";
            // 
            // button1
            // 
            button1.Location = new Point(161, 101);
            button1.Name = "button1";
            button1.Size = new Size(98, 33);
            button1.TabIndex = 3;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(43, 101);
            button3.Name = "button3";
            button3.Size = new Size(112, 33);
            button3.TabIndex = 5;
            button3.Text = "Choose a file";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 140);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 298);
            textBox1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(350, 101);
            button2.Name = "button2";
            button2.Size = new Size(95, 44);
            button2.TabIndex = 7;
            button2.Text = "Creat word list";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(465, 103);
            button4.Name = "button4";
            button4.Size = new Size(95, 41);
            button4.TabIndex = 8;
            button4.Text = "Sort words";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(367, 151);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(160, 304);
            listBox1.TabIndex = 9;
            // 
            // button5
            // 
            button5.Location = new Point(635, 106);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 10;
            button5.Text = "Count";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(615, 151);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 304);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(button5);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button3;
        private TextBox textBox1;
        private Button button2;
        private Button button4;
        private ListBox listBox1;
        private Button button5;
        private ListView listView1;
    }
}