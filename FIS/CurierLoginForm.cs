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
    public partial class CurierLoginForm : Form
    {
        public CurierLoginForm()
        {
            InitializeComponent();
        }
        private void CurierLoginForm_Load(object sender, EventArgs e)
        {
            string[] admins = File.ReadAllLines("C:\\Users\\user\\source\\repos\\FormPay\\FIS\\curier.txt");
            foreach (var line in admins)
            {
                string[] inregistrare = line.Split(';');
                comboBox1.Items.Add(inregistrare[0]);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormInitialcs initial =new FormInitialcs();
            initial.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] admins = File.ReadAllLines("C:\\Users\\user\\source\\repos\\FormPay\\FIS\\curier.txt");

            foreach (var line in admins)
            {
                string[] inregistrare = line.Split(';');
                if ((comboBox1.Text).Equals(inregistrare[0]))
                {
                    if ((textBox1.Text.Trim()).Equals(inregistrare[1].Trim()))
                    {
                        Colet colet = Data.Colet;
                       // FormAdminLogged f = new FormAdminLogged(colet);
                        FormColete f = new FormColete(colet);
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

       
    }
}
