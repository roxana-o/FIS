using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIS
{
    public partial class FormInitialcs : Form
    {
        public FormInitialcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserConnectForm user = new UserConnectForm();
            user.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminLoginForm admin = new AdminLoginForm();
            admin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurierLoginForm curier = new CurierLoginForm();
            curier.Show();
            this.Hide();
        }
    }
}
