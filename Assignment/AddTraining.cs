using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class AddT : Form
    {
        public AddT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DateTime STime, ETime;
            STime = DateTime.Parse(SText.Text);
            ETime = DateTime.Parse(EText.Text);

            String TrainingLevel = lvlText.Text;
        }

        private void AddT_Load(object sender, EventArgs e)
        {

        }
    }
}
