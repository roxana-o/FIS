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
using System.Xml;

namespace FIS
{
    public partial class FormColete : Form
    {
        private string xmlFilePath = "C:\\Users\\user\\source\\repos\\FormPay\\FIS\\coletele2.xml";
        private DataTable dataTable;


        public FormColete(Colet colet)
        {
            InitializeComponent();
            dataTable = new DataTable();
            InitializeDataTable();
        }
        private void InitializeDataTable()
        {
            dataTable.Columns.Add("Nume");
            dataTable.Columns.Add("Prenume");
            dataTable.Columns.Add("Oras");
            dataTable.Columns.Add("Numardetelefon");
            dataTable.Columns.Add("NumeDestinatar");
            dataTable.Columns.Add("PrenumeDestinatar");
            dataTable.Columns.Add("OrasDestinatar");
            dataTable.Columns.Add("NumardetelefonDestinatar");
            dataTable.Columns.Add("Greutatecolet");
            dataTable.Columns.Add("Tip");
            dataTable.Columns.Add("PretLivrare");
            dataTable.Columns.Add("OreLivrare");

            dataGridView1.DataSource = dataTable;
        }


        private void FormColete_Load(object sender, EventArgs e)
        {

            LoadXMLData();
        }

        private void LoadXMLData()
        {
            // Clear existing data
            dataTable.Clear();

            // Load the XML file
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            // Extract the data from XML and populate the DataTable
            XmlNodeList productNodes = xmlDoc.SelectNodes("//DateFormular/Nume");

            foreach (XmlNode productNode in productNodes)
            {
                DataRow row = dataTable.NewRow();
                row["Nume"] = productNode.InnerText;
                row["Prenume"] = productNode.NextSibling.InnerText;
                row["Oras"] = productNode.NextSibling.NextSibling.InnerText;
                row["Numardetelefon"] = productNode.NextSibling.NextSibling.NextSibling.InnerText;
                row["NumeDestinatar"] = productNode.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                row["PrenumeDestinatar"] = productNode.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                row["OrasDestinatar"] = productNode.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                row["NumardetelefonDestinatar"] = productNode.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                row["Greutatecolet"] = productNode.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                row["Tip"] = productNode.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                row["PretLivrare"] = productNode.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
                row["OreLivrare"] = productNode.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;

                dataTable.Rows.Add(row);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadXMLData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
