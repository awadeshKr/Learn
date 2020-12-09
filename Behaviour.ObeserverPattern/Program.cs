using Behaviour.ObeserverPattern.Class;
using System;

namespace Behaviour.ObeserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var subject = new Subject();
            subject.Attache(new ObserverA());
            subject.Attache(new ObserverB());
            subject.SetState(1);


        }
    }
}
