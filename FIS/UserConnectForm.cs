using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FIS
{
    public partial class UserConnectForm : Form
    {
        public UserConnectForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] admins = File.ReadAllLines("C:\\Users\\user\\source\\repos\\FormPay\\FIS\\client.txt");

            foreach (var line in admins)
            {
                string[] inregistrare = line.Split(';');
                if ((textBox1.Text).Equals(inregistrare[0]))
                {
                    if ((textBox1.Text.Trim()).Equals(inregistrare[1].Trim()))
                    {
                        Colet colet = Data.Colet;
                       UserDepunereColet f =new UserDepunereColet();
                        this.Hide();
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Parola incorecta!");
                    }
                }
            }
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInitialcs initial = new FormInitialcs();
            initial.Show();
            this.Hide();
        }
    }
}
