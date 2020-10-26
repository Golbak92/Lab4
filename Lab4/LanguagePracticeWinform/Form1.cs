using LanguageLibrary;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LanguagePracticeWinform
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var files = WordList.GetLists();
            foreach (var file in files)
            {
                listBox1.Items.Add(file);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var name = listBox1.SelectedItem.ToString();
                var languageArray = WordList.LoadList(name).Languages;
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();

                foreach (var languages in languageArray)
                {
                    dataGridView.Columns.Add("", languages.ToUpper());

                }

                var languageNum = 0;
                WordList.LoadList(name).List(languageNum, x =>
                {
                        dataGridView.Rows.Add(x);
                });

                WordCounter.Text = "WordCounter: " + WordList.LoadList(name).Count().ToString();
            }
        }

        private void buttonNewList_Click(object sender, EventArgs e)
        {
            NewList newList = new NewList();

            if (newList.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
