using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hehehe
{
    public partial class MemberHome : Form
    {
        public static MemberHome instance;
        public Label tc;
        public Label n;
        public Label ID;
        public string email;
        private string connectionString;
        public MemberHome(string email)
        {
            InitializeComponent();
            instance = this;
            connectionString = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;
            this.email = email;
            lblemail.Text = email;
        }

        private void enroll_unenroll_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            enrollform f2 = new enrollform(email);
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {

            this.Hide();
            updateprofile f3 = new updateprofile(email);
            f3.ShowDialog();
            f3 = null;
            this.Show();
        }

        private void name_Click(object sender, EventArgs e)
        {
            
        }

        private void schedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberSchedule f4 = new MemberSchedule();
            f4.ShowDialog();
            f4 = null;
            this.Show();
        }

        private void id_Click(object sender, EventArgs e)
        {

        }
    }
}
