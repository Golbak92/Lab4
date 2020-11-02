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
    public partial class FormPractice : Form
    {
        public string fileName { get; set; }

        public FormPractice(string name)
        {
            InitializeComponent();
            fileName = name;
        }

        private void FormPractice_Load(object sender, EventArgs e)
        {
            // 1. ladda in listan som man valt
            // 2. ladda getpractice metoden som jag sparar till en ny word object
            // 3. sätta label till sträng t.ex. " översätt fr - till"
            // 4. kolla så att textboxen är == toLanguage ordet
        }
        private void buttonPracticeRestart_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit(object sender, EventArgs e)
        {
            Close();
        }

    }
}
