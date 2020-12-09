using System;
using System.Collections.Generic;
using System.Text;

namespace Behaviour.ObeserverPattern.Interface
{
    public interface ISubject
    {
        void Attache(IObserver observer);
        void Deattach(IObserver observer);
        void Notify();
    }
}
