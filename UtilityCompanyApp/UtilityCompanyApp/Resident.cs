using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityCompanyApp
{
    public class Resident
    {
        public string Name { get; set; }
        public Dictionary<string, double> ConsumedServices { get; set; }

        public Resident(string name) : this()
        {
            Name = name;
            
        }
        public Resident()
        {
            ConsumedServices = new Dictionary<string, double>();
        }
        public void AddConsumedService(string serviceName, double quantity)
        {
            if (ConsumedServices.ContainsKey(serviceName))
            {
                ConsumedServices[serviceName] += quantity;  
            }
            else
            {
                ConsumedServices.Add(serviceName, quantity);  // Додаємо нову послугу
            }
        }

        public double GetTotalAmount(Dictionary<string, Tariff> tariffs)
        {
            double totalAmount = 0;
            foreach (var consumedService in ConsumedServices)
            {
                if (tariffs.ContainsKey(consumedService.Key))
                {
                    totalAmount += tariffs[consumedService.Key].Rate * consumedService.Value;
                }
            }
            return totalAmount;
        }
    }
}
