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
    public partial class homeManager : Form
    {
        public homeManager()
        {
            InitializeComponent();
        }

        private void ManagerHome_Load(object sender, EventArgs e)
        {

        }

        private void lblComManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCompetition obj1 = new frmCompetition();
            obj1.Show();
        }

        private void lblStuRecommendation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmStudentRE obj1 = new frmStudentRE();
            obj1.Show();
        }

        private void lblMemAssignment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMberAssign obj1 = new frmMberAssign();
            obj1.Show();
        }

        private void lblComDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewComDetail obj1 = new frmViewComDetail();
            obj1.Show();
        }

        private void lblComResult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmComResult obj1 = new frmComResult();
            obj1.Show();
        }
    }
}
