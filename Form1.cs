namespace WordCountAppNB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String filepath = openFileDialog.FileName;
                textBox1.Text = File.ReadAllText(filepath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String allwords = textBox1.Text;
            String[] wordsArray = allwords.Split(' ', ',', '.', '_');

            foreach (String word in wordsArray)
            {
                if (!listBox1.Items.Contains(word))
                {
                    listBox1.Items.Add(word);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            String allwords = textBox1.Text;
            String[] wordsArray = allwords.Split(' ', ',', '.', '_');

            //Change the array into a list. A list has more features than an array.
            //The list can use the command to see if the word is already in the list.
            List<wordCounter> wordCounters = new List<wordCounter>(); 

            //go through the word array. if the is found int he list, add 1 to the frequency to 1
            foreach (string w in wordsArray)
            {
                wordCounter foundWord = wordCounters.Find(x =>x.word == w);
                if (foundWord == null) {

                    //the word is not in the list

                    wordCounters.Add(new wordCounter(w, 1));
                }

                else
                {
                    foundWord.frequency++;
                }
            }

        }
    }
}