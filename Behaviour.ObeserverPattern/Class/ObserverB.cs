using Behaviour.ObeserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behaviour.ObeserverPattern.Class
{
    public class ObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("I Got the update - ObserverB");
        }
    }
}
