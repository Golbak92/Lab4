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

        }

        private void buttonExit(object sender, EventArgs e)
        {
            Close();
        }
    }
}
