
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace FIS
{
    public partial class FormPay : Form
    {
        private List<Colet> products;
        
        public FormPay()
        {
            InitializeComponent();

        }

       

        private List<Colet> LoadProductsFromJson(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Colet>>(json);
            }
        }

        private bool ValidateCardDetails()
        {
            string cardNumber = txtCardNumber.Text;
            string expirationDate = txtExpirationDate.Text;
            string cvv = txtCVV.Text;

            bool isValid = IsCreditCardInfoValid(cardNumber, expirationDate, cvv);

            if (!isValid)
            {
                MessageBox.Show("Datele cardului bancar nu sunt valide!");
            }

            return isValid;
        }

        public static bool IsCreditCardInfoValid(string cardNo, string expiryDate, string cvv)
        {
            var cardCheck = new Regex(@"^(1298|1267|4512|4567|8901|8933)([\-\s]?[0-9]{4}){3}$");
            var monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
            var yearCheck = new Regex(@"^20[0-9]{2}$");
            var cvvCheck = new Regex(@"^\d{3}$");

            if (!cardCheck.IsMatch(cardNo)) // <1>check card number is valid
                return false;
            if (!cvvCheck.IsMatch(cvv)) // <2>check cvv is valid as "999"
                return false;

            var dateParts = expiryDate.Split('/'); //expiry date in from MM/yyyy            
            if (!monthCheck.IsMatch(dateParts[0]) || !yearCheck.IsMatch(dateParts[1])) // <3 - 6>
                return false; // ^ check date format is valid as "MM/yyyy"

            var year = int.Parse(dateParts[1]);
            var month = int.Parse(dateParts[0]);
            var lastDateOfExpiryMonth = DateTime.DaysInMonth(year, month); //get actual expiry date
            var cardExpiry = new DateTime(year, month, lastDateOfExpiryMonth, 23, 59, 59);

            //check expiry greater than today & within next 6 years <7, 8>>
            return (cardExpiry > DateTime.Now && cardExpiry < DateTime.Now.AddYears(6));
        }




        private void SavePaymentInformation()
        {
            string sourceFilePath = "C:\\Users\\user\\source\\repos\\FormPay\\FIS\\coletele.xml";
            string destinationFilePath = "C:\\Users\\user\\source\\repos\\FormPay\\FIS\\coletele2.xml";

            // Read the contents of the source JSON file
            string jsonContent = File.ReadAllText(sourceFilePath);

            // Write the contents to the destination file
            File.WriteAllText(destinationFilePath, jsonContent);
            // Save product information to another file
            
            Random random = new Random();

            // Generate a random number between a specified range
            int randomNumber = random.Next(10000, 99999);

            // Display the random number
            label3.Text = "ID comandă: " + randomNumber.ToString();

            MessageBox.Show("Operația a fost efectuată cu succes! Statusul coletului: în tranzit direct");

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Perform cash payment logic

                // Save product information to another file
                SavePaymentInformation();
            }
            else if (radioButton2.Checked)
            {
                if (ValidateCardDetails())
                {
                    // Perform card payment logic

                    // Save product information to another file
                    SavePaymentInformation();
                }
            }
            else
            {
                MessageBox.Show("Alegeți o modalitate de plată!");
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                // Show card details controls
                lblCash.Visible = false;
                lblCardName.Visible = true;
                txtCardName.Visible = true;
                lblCardNumber.Visible = true;
                txtCardNumber.Visible = true;
                lblExpirationDate.Visible = true;
                txtExpirationDate.Visible = true;
                lblCVV.Visible = true;
                txtCVV.Visible = true;

            }
            else
            {
                // Hide card details controls
                lblCash.Visible = true;
                lblCardName.Visible = false;
                txtCardName.Visible = false;
                lblCardNumber.Visible = false;
                txtCardNumber.Visible = false;
                lblExpirationDate.Visible = false;
                txtExpirationDate.Visible = false;
                lblCVV.Visible = false;
                txtCVV.Visible = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            UserDepunereColet colet = new UserDepunereColet();
            colet.Show();
            this.Hide();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
