using LanguageLibrary;
using System;
using System.Windows.Forms;

namespace LanguagePracticeWinform
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            listboxListNames.Items.Clear();
            var files = WordList.GetLists();
            foreach (var file in files)
            {
                listboxListNames.Items.Add(file);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxListNames.SelectedItem != null)
            {
                var name = listboxListNames.SelectedItem.ToString();
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

        private void buttonCreateNewList(object sender, EventArgs e)
        {
            FormNewList newList = new FormNewList();
            newList.ShowDialog();
        }

        private void buttonAddNewWords(object sender, EventArgs e)
        {
            if (listboxListNames.SelectedItem == null)
            {
                MessageBox.Show("Choose a list you wish to add words in first!");
            }
            else
            {
            FormAddWords addWords = new FormAddWords(listboxListNames.SelectedItem.ToString());
            addWords.ShowDialog();
            }
        }

        private void buttonPracticeMode(object sender, EventArgs e)
        {
            if (listboxListNames.SelectedItem == null)
            {
                MessageBox.Show("Choose a list you wish to practice on first!");
            }
            else
            {
                FormPractice practice = new FormPractice(listboxListNames.SelectedItem.ToString());
                practice.ShowDialog();
            }
        }

        private void buttonRemoveWords(object sender, EventArgs e)
        {
            var list = listboxListNames.SelectedItem.ToString();
            var removeWords = WordList.LoadList(UserInput(args)[1]);
            var languageInt = 0;

            for (int i = 0; i < removeWords.Languages.Length; i++)
            {
                if (removeWords.Languages[i] == UserInput(args)[2])
                {
                    languageInt = i;
                }
            }

            for (int i = 3; i < UserInput(args).Length; i++)
            {
                removeWords.Remove(languageInt, UserInput(args)[i]);
            }
            removeWords.Save();
        }
    }
}
