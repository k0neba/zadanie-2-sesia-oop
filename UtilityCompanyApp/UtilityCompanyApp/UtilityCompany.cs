using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace UtilityCompanyApp
{
    public class UtilityCompany
    {
        public Dictionary<string, Tariff> Tariffs { get; set; }
        public List<Resident> Residents { get; set; }

        

        public UtilityCompany()
        {
            Tariffs = new Dictionary<string, Tariff>();
            Residents = new List<Resident>();
        }

       
        public void AddTariff(string serviceName, double rate)
        {
            if (!Tariffs.ContainsKey(serviceName))
            {
                Tariffs.Add(serviceName, new Tariff(serviceName, rate));
            }
            else
            {
                Tariffs[serviceName].Rate = rate;  
            }
        }

       
        public void AddResident(string residentName)
        {
            Residents.Add(new Resident(residentName));
        }

      
        public void AddConsumedServiceForResident(string residentName, string serviceName, double quantity)
        {
            var resident = Residents.Find(r => r.Name == residentName);
            if (resident != null)
            {
                resident.AddConsumedService(serviceName, quantity);
            }
        }

        
        public double GetResidentTotalAmount(string residentName)
        {
            var resident = Residents.Find(r => r.Name == residentName);
            return resident?.GetTotalAmount(Tariffs) ?? 0;
        }

        
        public double GetTotalCostOfAllServices()
        {
            double totalCost = 0;
            foreach (var resident in Residents)
            {
                totalCost += resident.GetTotalAmount(Tariffs);
            }
            return totalCost;
        }

        // Збереження даних у XML
        public void SaveToXml(string fileName)
        {
            var root = new XElement("UtilityCompany");

            
            var tariffsElement = new XElement("Tariffs");
            foreach (var tariff in Tariffs.Values)
            {
                tariffsElement.Add(new XElement("Tariff",
                    new XAttribute("ServiceName", tariff.ServiceName),
                    new XAttribute("Rate", tariff.Rate)
                ));
            }
            root.Add(tariffsElement);

            
            var residentsElement = new XElement("Residents");
            foreach (var resident in Residents)
            {
                residentsElement.Add(new XElement("Resident", new XAttribute("Name", resident.Name)));
            }
            root.Add(residentsElement);

            // Зберігаємо XML файл
            var doc = new XDocument(root);
            doc.Save(fileName);
        }

        // Завантаження даних з XML
        public static UtilityCompany LoadFromXml(string fileName)
        {
            var company = new UtilityCompany();
            var doc = XDocument.Load(fileName);
            var root = doc.Element("UtilityCompany");

            // Завантажуємо тарифи
            var tariffsElement = root.Element("Tariffs");
            foreach (var tariffElement in tariffsElement.Elements("Tariff"))
            {
                var serviceName = tariffElement.Attribute("ServiceName")?.Value;
                var rate = double.Parse(tariffElement.Attribute("Rate")?.Value ?? "0");
                company.Tariffs[serviceName] = new Tariff(serviceName, rate);
            }

            // Завантажуємо резидентів
            var residentsElement = root.Element("Residents");
            foreach (var residentElement in residentsElement.Elements("Resident"))
            {
                var name = residentElement.Attribute("Name")?.Value;
                company.Residents.Add(new Resident(name));
            }

            return company;
        }
    }
}