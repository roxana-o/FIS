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

namespace FIS
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
            string[] admins = File.ReadAllLines("C:\\Users\\user\\source\\repos\\FormPay\\FIS\\admin.txt");
            foreach (var line in admins)
            {
                string[] inregistrare = line.Split(';');
                comboBox1.Items.Add(inregistrare[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] admins = File.ReadAllLines("C:\\Users\\user\\source\\repos\\FormPay\\FIS\\admin.txt");

            foreach (var line in admins)
            {
                string[] inregistrare = line.Split(';');
                if ((comboBox1.Text).Equals(inregistrare[0]))
                {
                    if ((textBox1.Text.Trim()).Equals(inregistrare[1].Trim()))
                    {
                        Colet colet = Data.Colet;
                        FormAdminLogged f = new FormAdminLogged(colet);
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

        private void button2_Click(object sender, EventArgs e)
        {
            FormInitialcs initial = new FormInitialcs();
            initial.Show();
            this.Hide();
        }
    }
    
}
