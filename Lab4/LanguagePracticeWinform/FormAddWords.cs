using LanguageLibrary;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LanguagePracticeWinform
{
    public partial class FormAddWords : Form
    {
        public string Name { get; set; }

        public FormAddWords(string name)
        {
            InitializeComponent();
            Name = name;
        }

        private void FormAddWords_Load(object sender, EventArgs e)
        {
            var languages = WordList.LoadList(Name).Languages;
            foreach (var language in languages)
            {
                dataGridViewAddWords.Columns.Add("Languages", language.ToUpper());
            }
            dataGridViewAddWords.Rows.Add();
        }

        private void buttonAddWordsConfirm_Click(object sender, EventArgs e)
        {
            var wordList = WordList.LoadList(Name);
            var wordsArray = new string[wordList.Languages.Length];
            for (int i = 0; i < dataGridViewAddWords.Rows.Count; i++)
            {
                for (int j = 0; j < wordsArray.Length; j++)
                {
                    if (dataGridViewAddWords.Rows[i].Cells[j].Value != null)
                    {
                        wordsArray[j] = dataGridViewAddWords.Rows[i].Cells[j].Value.ToString();
                    }
                }

                if (!wordsArray.Contains(null))
                {
                    wordList.Add(wordsArray);
                }
            }
            wordList.Save();
            Close();
        }

        private void buttonAddWordsCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
