using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPractice
{
    internal class WeatherStation   :ISubject
    {
        List<IObserver> _observers;
        
        public float Temperature
        {
            get {  return _temperature; }
            set
            {
               _temperature = value;
                Notify();
            }
        }


        private float _temperature;

        public WeatherStation()
        {
            _observers = new List<IObserver>();
        }


        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Notify()
        {
            _observers.ForEach(observer =>
            {
                observer.Update(this);
            });
        }
    }
}
