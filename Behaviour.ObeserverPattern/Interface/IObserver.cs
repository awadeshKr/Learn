using System;
using System.Collections.Generic;
using System.Text;

namespace Behaviour.ObeserverPattern.Interface
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
