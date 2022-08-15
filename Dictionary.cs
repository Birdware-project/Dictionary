namespace វចនានុក្រម
{
    public partial class Dictionary : Form
    {
        public List<string> database_word = new List<string>()
            {
                "Apple",
                "Banana",
                "Bat",
                "Coconut",
                "Durian",
                "Elderberries",
                "Figs",
                "Grapes",
                "HoneyDewMelon",
                "JackFruit",
                "KiwiFruit",
                "Longan",
                "Mango",
                "Orange",
                "Peaches",
                "Pineapple"
            };
        public Dictionary()
        {
            InitializeComponent();
            
            foreach (string data in this.database_word)
            {
                this.listbox_word.Items.Add(data);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ចកចញToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listbox_word_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void database(string keyword)
        {
            switch (keyword)
            {
                case "Apple":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Apple ( n ) ផ្លែប៉ោម ");
                    break;
                case "Banana":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Banana ( n )  ផ្លែចេក ");
                    break;
                case "Bat":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Bat ( n )  សត្វប្រចៀវ ");
                    break;
                case "Coconut":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Coconut ( n )  ផ្លែដូង ");
                    break;
                case "Durian":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Durian ( n )  ផ្លែធូរ៉េន ");
                    break;
                case "Elderberries":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Elderberries ( n )  ផ្លែបីរី ");
                    break;
                case "Figs":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Figs ( n )  ផ្លែល្វា ");
                    break;
                case "Grapes":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Grapes ( n )  ផ្លែទំពាំងបាយជូរ ");
                    break;
                case "HoneyDewMelon":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("HoneyDewMelon ( n )  ផ្លែឪឡឹកទឹកឃ្មុំ ");
                    break;
                case "JackFruit":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("JackFruit ( n )  ផ្លែខ្នុល ");
                    break;
                case "KiwiFruit":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("KiwiFruit ( n )  ផ្លែគីវី ");
                    break;
                case "Longan":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Longan ( n )  ផ្លែមាន ");
                    break;
                case "Mango":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Mango ( n )  ផ្លែស្វាយ ");
                    break;
                case "Orange":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Orange ( n )  ផ្លែក្រូច ");
                    break;
                case "Peaches":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Peaches ( n )  ផ្លែប៉េស ");
                    break;
                case "Pineapple":
                    this.richTextBox_answer.ResetText();
                    this.richTextBox_answer.AppendText("Pineapple ( n )  ផ្លែម្នាស់ ");
                    break;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            string keyword = this.listbox_word.Text;
            database(keyword);
        }

        private void SearchWord(object sender, EventArgs e)
        {

            foreach(string word_input in this.database_word)
            {
                if (this.textBox_search.Text.ToLower() == word_input.ToLower())
                {
                    foreach (string data in this.database_word)
                    {
                        this.listbox_word.Items.Remove(data);
                    }
                    this.listbox_word.Items.Add(word_input);
                }
                else if (this.textBox_search.Text.ToLower() == "")
                {
                    foreach (string data in this.database_word)
                    {
                        this.listbox_word.Items.Remove(data);
                    }
                    foreach (string data in this.database_word)
                    {
                        this.listbox_word.Items.Add(data);
                    }
                }
            }
        }

        private void អពToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void ToolStripMenuItemDoc_Click(object sender, EventArgs e)
        {
            Doc doc = new Doc();
            doc.ShowDialog();
        }

        private void មតអនកបរបរសToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void listbox_word_Click(object sender, EventArgs e)
        {

        }
    }
}
