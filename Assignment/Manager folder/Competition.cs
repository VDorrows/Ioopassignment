using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class frmCompetition : Form
    {
        public frmCompetition()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblManagerHome_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCompetition_Click(object sender, EventArgs e)
        {
            frmComAdd obj1 = new frmComAdd();
            obj1.Show();
        }

        private void btnDeleteCompetition_Click(object sender, EventArgs e)
        {
            frmComDel obj1 = new frmComDel();
            obj1.Show();
        }

        private void btnEditCompetiton_Click(object sender, EventArgs e)
        {
            frmComEdit obj1 = new frmComEdit();
            obj1.Show();
        }
    }
}
