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
using System.Xml;

namespace FIS
{
    public partial class UserDepunereColet : Form
    {
        public UserDepunereColet()
        {
            InitializeComponent();
        }

        private void UserDepunereColet_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Normal", "Fragil", "Livrare speciala", "Pretios" });
            comboBox2.Items.AddRange(new string[] { "Bucuresti", "Pitesti", "Botosani", "Craiova", "Timisoara" });
            comboBox3.Items.AddRange(new string[] { "Bucuresti", "Pitesti", "Botosani", "Tulcea", "Timisoara" });
        }

        private Label GetPretLivrare()
        {
            return PretLivrare;
        }



        private double Calculare(double greutate, string oras, string tip)
        {
            double pret = 0;
            if (oras == "Bucuresti")
            {
                if (tip == "Normal")
                {
                    pret = greutate * 15;
                }
                else if (tip == "Fragil")
                {
                    pret = greutate * 25;
                }
                else if (tip == "Livrare speciala")
                {
                    pret = greutate * 35;
                }
                else
                {
                    pret = greutate * 50;
                }
            }
            else if (oras == "Pitesti")
            {
                if (tip == "Normal")
                {
                    pret = greutate * 10;
                }
                else if (tip == "Fragil")
                {
                    pret = greutate * 20;
                }
                else if (tip == "Livrare speciala")
                {
                    pret = greutate * 25;
                }
                else
                {
                    pret = greutate * 40;
                }
            }
            else if (oras == "Botosani")
            {
                if (tip == "Normal")
                {
                    pret = greutate * 10;
                }
                else if (tip == "Fragil")
                {
                    pret = greutate * 20;
                }
                else if (tip == "Livrare speciala")
                {
                    pret = greutate * 25;
                }
                else
                {
                    pret = greutate * 40;
                }
            }
            else if (oras == "Craiova")
            {
                if (tip == "Normal")
                {
                    pret = greutate * 16;
                }
                else if (tip == "Fragil")
                {
                    pret = greutate * 22;
                }
                else if (tip == "Livrare speciala")
                {
                    pret = greutate * 29;
                }
                else
                {
                    pret = greutate * 45;
                }
            }
            else
            {
                if (tip == "Normal")
                {
                    pret = greutate * 10;
                }
                else if (tip == "Fragil")
                {
                    pret = greutate * 15;
                }
                else if (tip == "Livrare speciala")
                {
                    pret = greutate * 20;
                }
                else
                {
                    pret = greutate * 40;
                }
            }
            return pret;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 && comboBox2.SelectedIndex >= 0 && comboBox3.SelectedIndex >= 0
    && comboBox2.Text != comboBox3.Text && textBox5.Text != "")
            {
                MessageBox.Show("Datele au fost salvate!");

                FormPay form = new FormPay();
                this.Hide();
                form.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Formularul nu este completat in totalitate!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double CalculareTimp(string oras, string tip)
        {
            double nr_ore = 0;
            if (oras == "Bucuresti")
            {
                if (tip == "Normal")
                {
                    nr_ore = 72;
                }
                else if (tip == "Fragil")
                {
                    nr_ore = 80;
                }
                else if (tip == "Livrare speciala")
                {
                    nr_ore = 60;
                }
                else
                {
                    nr_ore = 100;
                }
            }
            else if (oras == "Pitesti")
            {
                if (tip == "Normal")
                {
                    nr_ore = 68;
                }
                else if (tip == "Fragil")
                {
                    nr_ore = 76;
                }
                else if (tip == "Livrare speciala")
                {
                    nr_ore = 56;
                }
                else
                {
                    nr_ore = 85;
                }
            }
            else if (oras == "Botosani")
            {
                if (tip == "Normal")
                {
                    nr_ore = 63;
                }
                else if (tip == "Fragil")
                {
                    nr_ore = 76;
                }
                else if (tip == "Livrare speciala")
                {
                    nr_ore = 45;
                }
                else
                {
                    nr_ore = 56;
                }
            }
            else if (oras == "Craiova")
            {
                if (tip == "Normal")
                {
                    nr_ore = 50;
                }
                else if (tip == "Fragil")
                {
                    nr_ore = 55;
                }
                else if (tip == "Livrare speciala")
                {
                    nr_ore = 44;
                }
                else
                {
                    nr_ore = 60;
                }
            }
            else
            {
                if (tip == "Normal")
                {
                    nr_ore = 24;
                }
                else if (tip == "Fragil")
                {
                    nr_ore = 36;
                }
                else if (tip == "Livrare speciala")
                {
                    nr_ore = 12;
                }
                else
                {
                    nr_ore = 48;
                }
            }
            return nr_ore;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 && comboBox2.SelectedIndex >= 0 && comboBox3.SelectedIndex >= 0
     && comboBox2.Text != comboBox3.Text && textBox7.Text != "")
            {
                string filePath = "C:\\Users\\user\\source\\repos\\FormPay\\FIS\\coletele.xml";
                XmlDocument xmlDocument = new XmlDocument();

                try 
                {
                    xmlDocument.Load(filePath);
                }

                catch (XmlException)
                {
                  
                    XmlElement newrootElement = xmlDocument.CreateElement("\n DateFormular");
                    xmlDocument.AppendChild(newrootElement);
                }
                
                XmlElement numeUser = xmlDocument.CreateElement("Nume");
                numeUser.InnerText = textBox1.Text;
                XmlElement prenumeUser = xmlDocument.CreateElement("Prenume");
                prenumeUser.InnerText = textBox2.Text;
                XmlElement orasUser = xmlDocument.CreateElement("Oras");
                orasUser.InnerText = comboBox2.Text;
                XmlElement nrTelefonUser = xmlDocument.CreateElement("Numardetelefon");
                nrTelefonUser.InnerText = textBox3.Text;

                XmlElement numeDest = xmlDocument.CreateElement("NumeDestinatar");
                numeDest.InnerText = textBox4.Text;
                XmlElement prenumeDest = xmlDocument.CreateElement("PrenumeDestinatar");
                prenumeDest.InnerText = textBox5.Text;
                XmlElement orasDest = xmlDocument.CreateElement("OrasDestinatar");
                orasDest.InnerText = comboBox3.Text;
                XmlElement nrTelefonDest = xmlDocument.CreateElement("NumardetelefonDestinatar");
                nrTelefonDest.InnerText = textBox6.Text;

                XmlElement greutateColet = xmlDocument.CreateElement("Greutatecolet");
                greutateColet.InnerText = textBox7.Text;
                XmlElement tipColet = xmlDocument.CreateElement("Tip");
                tipColet.InnerText = comboBox1.Text;

                XmlNode rootElement = xmlDocument.SelectSingleNode("DateFormular");
                rootElement.AppendChild(numeUser);
                rootElement.AppendChild(prenumeUser);
                rootElement.AppendChild(orasUser);
                rootElement.AppendChild(nrTelefonUser);

                rootElement.AppendChild(numeDest);
                rootElement.AppendChild(prenumeDest);
                rootElement.AppendChild(orasDest);
                rootElement.AppendChild(nrTelefonDest);

                rootElement.AppendChild(greutateColet);
                rootElement.AppendChild(tipColet);



                double greutate = Double.Parse(greutateColet.InnerText);
                string oras = comboBox2.SelectedItem.ToString();
                string tip = comboBox1.SelectedItem.ToString();
                double pret = Calculare(greutate, oras, tip);
                PretLivrare.Text = pret.ToString();
                double ore = CalculareTimp(oras, tip);
                TimpLivrare.Text = ore.ToString();

                XmlElement pretCol = xmlDocument.CreateElement("PretLivrare");
                pretCol.InnerText = pret.ToString();
                XmlElement oreLiv = xmlDocument.CreateElement("OreLivrare");
                oreLiv.InnerText = ore.ToString();

                rootElement.AppendChild(pretCol);
                rootElement.AppendChild(oreLiv);

                xmlDocument.AppendChild(rootElement);

                
                xmlDocument.Save(filePath);
               
            }
            }
    }
}
