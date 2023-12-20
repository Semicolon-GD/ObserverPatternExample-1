using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPractice
{
    internal class NewsAgency :IObserver
    {
       public string AgencyName {   get; set; }

        public NewsAgency(string agencyName)
        {
            AgencyName = agencyName;
        }

        public void Update(ISubject subject)
        {
           if (subject is WeatherStation weatherStation)
            {
                Console.WriteLine(string.Format("{0} reporting temperature {1} degree ", AgencyName,weatherStation.Temperature));
                Console.WriteLine();
            }
        }
    }
}
