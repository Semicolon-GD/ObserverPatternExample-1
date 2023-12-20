using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPractice
{
    internal interface IObserver
    {
        void Update(ISubject subject);
    }
}
