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
    public partial class FormAdminLogged : Form
    {
        public FormAdminLogged()
        {
            InitializeComponent();
        }

        private readonly TransportInfo transportInfo;
        public FormAdminLogged(Colet colet)
        {
            InitializeComponent();

            transportInfo = new TransportInfo("C:\\Users\\user\\source\\repos\\FormPay\\FIS\\transport_info.txt");
            // adăugăm coloanele la GridView-uri
            this.dataGridView1.Columns.Add("City", "Oraș");
            this.dataGridView2.Columns.Add("StartCity", "Oraș de plecare");
            this.dataGridView2.Columns.Add("EndCity", "Oraș de sosire");

            LoadData();
        }
        private void LoadData()
        {
            // Populăm GridView cu datele din lista de orașe
            foreach (var city in transportInfo.Cities)
            {
                dataGridView1.Rows.Add(city);
            }

            // Populăm GridView cu datele din lista de rute
            foreach (var route in transportInfo.Routes)
            {
                dataGridView2.Rows.Add(route.StartCity, route.EndCity);
            }

            // Afisam si datele din lista de orar si tip de transport in etichete
            label2.Text = "Orar: " + string.Join(", ", transportInfo.Schedule);
            //label3.Text = "Tip de transport: " + string.Join(", ", transportInfo.TransportType);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Colet colet = Data.Colet;
            FormColete f = new FormColete(colet);
            this.Hide();
            f.ShowDialog();
        }
    }
}
