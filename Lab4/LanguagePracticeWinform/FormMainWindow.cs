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
            if (listboxListNames.SelectedItem == null)
            {
                MessageBox.Show("Choose a list first that you wish to remove words from!");
            }
            else
            {
                var removeWords = WordList.LoadList(listboxListNames.SelectedItem.ToString());
                var selectedRows = dataGridView.SelectedRows;
                var languageInt = 0;

                if (selectedRows.Count != 0)
                {
                    foreach (DataGridViewRow words in selectedRows)
                    {
                        dataGridView.Rows.RemoveAt(words.Index);
                    }
                    removeWords.Remove(languageInt, selectedRows[0].Cells[0].Value.ToString());
                    removeWords.Save();
                }
            }
        }
    }
}