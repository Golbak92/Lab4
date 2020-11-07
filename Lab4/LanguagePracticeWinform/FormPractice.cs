using LanguageLibrary;
using System;
using System.Windows.Forms;

namespace LanguagePracticeWinform
{
    public partial class FormPractice : Form
    {
        public string fileName { get; set; }
        public WordList practiceList { get { return WordList.LoadList(fileName); } }
        public Word wordToPractice { get; set; }
        public int score { get; set; }

        public FormPractice(string name)
        {
            InitializeComponent();
            fileName = name;
        }

        private void FormPractice_Load(object sender, EventArgs e)
        {
            wordToPractice = practiceList.GetWordToPractice();

            FromToLanguage.Text = $"Translate from {practiceList.Languages[wordToPractice.FromLanguage]} to " +
                $"{practiceList.Languages[wordToPractice.ToLanguage]}.";

            labelPracticeWordOutput.Text = $"Type the correct answer of '{wordToPractice.Translations[wordToPractice.FromLanguage]}'";

            labelAnswerMessage.Hide();
        }

        private void buttonPracticeRestart_Click(object sender, EventArgs e)
        {
            score = 0;
            labelPracticeScore.Text = $"You got {score} points";
            MessageBox.Show("The practice mode is now restarted.");
        }

        private void buttonExit(object sender, EventArgs e)
        {
            Close();
        }

        private void textboxPracticeAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            var textBox = textboxPracticeAnswer.Text.ToLower();

            if (e.KeyCode == Keys.Enter)
            {
                if (textBox == wordToPractice.Translations[wordToPractice.ToLanguage].ToLower())
                {
                    labelAnswerMessage.Show();
                    labelAnswerMessage.Text = "Congratulations! The answer is correct!";
                    score++;
                }
                else
                {
                    labelAnswerMessage.Show();
                    labelAnswerMessage.Text = "Sorry, The answer is wrong!";
                }
                labelPracticeScore.Text = $"You got {score} points";

                wordToPractice = practiceList.GetWordToPractice();
                FromToLanguage.Text = $"Translate from {practiceList.Languages[wordToPractice.FromLanguage]} to " +
                $"{practiceList.Languages[wordToPractice.ToLanguage]}.";
                labelPracticeWordOutput.Text = $"Type the correct answer of '{wordToPractice.Translations[wordToPractice.FromLanguage]}'";
            }
        }
    }
}
