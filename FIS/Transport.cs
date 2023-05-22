using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIS
{
    public class TransportInfo
    {
        public List<string> Cities { get; set; }
        public List<Route> Routes { get; set; }
        public List<string> Schedule { get; set; }
        public List<string> TransportType { get; set; }


        public TransportInfo(string filePath)
        {
            Cities = new List<string>();
            Routes = new List<Route>();
            Schedule = new List<string>();
            TransportType = new List<string>();

            string[] lines = File.ReadAllLines("C:\\Users\\user\\source\\repos\\FormPay\\FIS\\transport_info.txt");

            List<string> currentSection = null;
            foreach (string line in lines)
            {
                if (line == "Cities")
                {
                    currentSection = Cities;
                }
                else if (line == "Routes")
                {
                    currentSection = null;
                    continue;
                }
                else if (line == "Schedule")
                {
                    currentSection = Schedule;
                }
                else if (line == "TransportType")
                {
                    currentSection = TransportType;
                }
                else if (currentSection != null)
                {
                    currentSection.Add(line);
                }
                else
                {
                    string[] parts = line.Split(',');
                    Routes.Add(new Route(parts[0], parts[1], int.Parse(parts[2])));
                }
            }
        }
        public double CalculatePrice(string startCity, string endCity, string categorieColet)
        {
            string transportType;
            // cautam ruta dintre cele doua orase
            Route route = Routes.FirstOrDefault(r => r.StartCity == startCity && r.EndCity == endCity);

            // calculam pretul in functie de tipul de transport
            double pricePerKm = 0.0;
            if (categorieColet == "Fragil")
                transportType = "train";
            else if (categorieColet == "Periculos" || categorieColet == "Pretios")
                transportType = "plane";
            else
                transportType = "bus";
            switch (transportType)
            {
                case "bus":
                    pricePerKm = 0.2;
                    break;
                case "train":
                    pricePerKm = 0.3;
                    break;
                case "plane":
                    pricePerKm = 0.5;
                    break;
                default:
                    throw new ArgumentException("Tipul de transport nu exista");
            }

            double price = pricePerKm * route.Distance;

            return price;
        }
        public int CalculateTime(string startCity, string endCity, string categorieColet)
        {
            string transportType;
            // cautam ruta dintre cele doua orase
            Route route = Routes.FirstOrDefault(r => r.StartCity == startCity && r.EndCity == endCity);

            // calculam timoul in functie de tipul de transport
            int time = 0; //in minutes
            if (categorieColet == "Fragil")
                transportType = "train";
            else if (categorieColet == "Periculos" || categorieColet == "Pretios")
                transportType = "plane";
            else
                transportType = "bus";
            switch (transportType)
            {
                case "bus":

                    time = 6;
                    break;
                case "train":
                    time = 8;
                    break;
                case "plane":
                    time = 1;
                    break;
                default:
                    throw new ArgumentException("Tipul de transport nu exista");
            }

            int finalTime = (int)((time * route.Distance) / 60);

            return finalTime;
        }

    }

    public class Route
    {
        public string StartCity { get; set; }
        public string EndCity { get; set; }
        public int Distance { get; set; }

        public Route(string startCity, string endCity, int distance)
        {
            StartCity = startCity;
            EndCity = endCity;
            Distance = distance;
        }

        public static List<Route> LoadRoutesFromFile(string filename)
        {
            List<Route> routes = new List<Route>();
            using (StreamReader reader = new StreamReader("transport_info.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');
                    string startCity = parts[0];
                    string endCity = parts[1];
                    int distance = int.Parse(parts[2]);
                    Route route = new Route(startCity, endCity, distance);
                    routes.Add(route);
                }
            }
            return routes;
        }
    }

}
