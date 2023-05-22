using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIS
{
    public class Colet
    {
        public string NumeClient { get; set; }
        public string PrenumeClient { get; set; }
        public string OrasClient { get; set; }
        public string TelefonClient { get; set; }
        public string NumeDestinatar { get; set; }
        public string PrenumeDestinatar { get; set; }
        public string OrasDestinatar { get; set; }
        public string TelefonDestinatar { get; set; }
        public double GreutateColet { get; set; }
        public string CategorieColet { get; set; }
        public string Status { get; set; }
        public string ID { get; set; }
        //upd

        public Colet() { }
        public Colet(string numeClient, string prenumeClient, string orasClient, string telefonClient,
                     string numeDestinatar, string prenumeDestinatar, string orasDestinatar, string telefonDestinatar,
                     double greutateColet, string categorieColet)
        {
            NumeClient = numeClient;
            PrenumeClient = prenumeClient;
            OrasClient = orasClient;
            TelefonClient = telefonClient;
            NumeDestinatar = numeDestinatar;
            PrenumeDestinatar = prenumeDestinatar;
            OrasDestinatar = orasDestinatar;
            TelefonDestinatar = telefonDestinatar;
            GreutateColet = greutateColet;
            CategorieColet = categorieColet;
        }

        public double CalculeazaPret(double greutateColet, string categorieColet)
        {
            double pret = GreutateColet * 2; //pretul standard
            if (CategorieColet == "Fragil") //daca este o categorie speciala
            {
                pret += 0.2 * pret; //adaugam un pret suplimentar
            }
            else
            if (CategorieColet == "Pretios") //daca este o categorie speciala
            {
                pret += 0.1 * pret; //adaugam un pret suplimentar
            }
            else
            if (CategorieColet == "Periculos") //daca este o categorie speciala
            {
                pret += 0.5 * pret; //adaugam un pret suplimentar
            }

            return pret;
        }
        public string AfiseazaInformatiiColet()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID colet: {this.ID}");
            sb.AppendLine($"Client: {this.NumeClient} {this.PrenumeClient}");
            sb.AppendLine($"Oras client: {this.OrasClient}");
            sb.AppendLine($"Telefon client: {this.TelefonClient}");
            sb.AppendLine($"Destinatar: {this.NumeDestinatar} {this.PrenumeDestinatar}");
            sb.AppendLine($"Oras destinatar: {this.OrasDestinatar}");
            sb.AppendLine($"Telefon destinatar: {this.TelefonDestinatar}");
            sb.AppendLine($"Greutate colet: {this.GreutateColet} kg");
            sb.AppendLine($"Categorie colet: {this.CategorieColet}");
            sb.AppendLine($"Status: {this.Status}");
            sb.AppendLine($"Pret: {this.CalculeazaPret(this.GreutateColet, this.CategorieColet)} RON");
            return sb.ToString();
        }

    }
}

