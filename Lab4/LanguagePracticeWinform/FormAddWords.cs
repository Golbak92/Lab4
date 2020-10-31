using LanguageLibrary;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LanguagePracticeWinform
{
    public partial class FormAddWords : Form
    {
        public string fileName { get; set; }

        public FormAddWords(string name)
        {
            InitializeComponent();
            fileName = name;
        }

        private void FormAddWords_Load(object sender, EventArgs e)
        {
            var languages = WordList.LoadList(fileName).Languages;
            foreach (var language in languages)
            {
                dataGridViewAddWords.Columns.Add("Languages", language.ToUpper());
            }
            dataGridViewAddWords.Rows.Add();
        }

        private void buttonAddWordsConfirm_Click(object sender, EventArgs e)
        {
            var wordList = WordList.LoadList(fileName);
            for (int i = 0; i < dataGridViewAddWords.Rows.Count; i++)
            {
                var wordsArray = new string[wordList.Languages.Length];
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
