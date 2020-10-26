using LanguageLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguagePracticeWinform
{
    public partial class FormAddWords : Form
    {
        public FormAddWords()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var languageNum = 0;
            WordList.LoadList().List(languageNum, x =>
            {
                dataGridView.Rows.Add(x);
            });
        }
        private void buttonAddWordsCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAddWords_Load(object sender, EventArgs e)
        {

        }
    }
}
