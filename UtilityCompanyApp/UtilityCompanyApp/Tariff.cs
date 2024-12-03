using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityCompanyApp
{
     public class Tariff
    {
        public string ServiceName { get; set; }
        public double Rate { get; set; }

        public Tariff(string serviceName, double rate)
        {
            ServiceName = serviceName;
            Rate = rate;
        }
        
        public Tariff() { }

        public override string ToString()
        {
            return $"{ServiceName}: {Rate} грн";
        }
    }
}