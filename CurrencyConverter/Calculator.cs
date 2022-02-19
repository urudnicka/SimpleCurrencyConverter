using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CurrencyConverter
{
    class Calculator
    {
        public static string Date { get; set; }
        public static Dictionary<string, double> Rates { get; set; }

        public Calculator()
        {
            ReadDataFile();
        }

        public static double ConvertEUR(double value, string currency)
        {
            double rate = Rates[currency];
            return value * rate;
        }

        public static bool IsItACurrency(string currency)
        {
            return Rates.ContainsKey(currency);
        } 

        public static void ListCurrencies()
        {
            Rates.Keys.ToList().ForEach(c => Console.Write("{0} ", c));
        }

        private static void ReadDataFile()
        {
            Rates = new Dictionary<string, double>();

            string filePath = @"..\..\Data\exchange_rates.xml";

            if (!File.Exists(filePath))
            {
                CreateDataFile(filePath);
            }

            XmlReader xmlReader = XmlReader.Create(filePath);

            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Cube"))
                {
                    if (xmlReader.HasAttributes)
                    {
                        if (xmlReader.GetAttribute("time") != null)
                            Date = xmlReader.GetAttribute("time");
                        else
                            Rates[xmlReader.GetAttribute("currency")] = Convert.ToDouble(xmlReader.GetAttribute("rate"));
                    }
                }
            }
        }

        private static void CreateDataFile(string path)
        {
            Directory.CreateDirectory(@"..\..\Data");

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");

            File.WriteAllText(path, xmlDoc.InnerXml);
        }

    }
}
