using LanguageLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguagePracticeWinform
{
    public partial class FormNewList : Form
    {
        public FormNewList()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonNewListOk_Click(object sender, EventArgs e)
        {
            var languageNames = textboxEnterLanguages.Lines;
            var wordlist = new WordList(textboxCreateNewList.Text, languageNames);
            wordlist.Save();
            MessageBox.Show("The list has been created.");
            
        }

        private void buttonNewListCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
