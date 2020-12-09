using Behaviour.ObeserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behaviour.ObeserverPattern.Class
{
    public class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public int state { get; set; } = -1;
        public void Attache(IObserver observer)
        {
            this._observers.Add(observer);
            
        }

        public void Deattach(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            _observers.ForEach(x => x.Update(this));
        }

        public void SetState(int state)
        {
            this.state = state;
            this.Notify();
        }
    }
}
