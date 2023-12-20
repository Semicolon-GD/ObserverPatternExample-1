using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPractice
{
    internal interface ISubject
    {
        void Attach(IObserver observer);
        void Notify();

    }
}
