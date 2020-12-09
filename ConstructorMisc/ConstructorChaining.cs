using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorMisc
{
    public abstract class TestA
    {
        public TestA()
        {
            Console.WriteLine("TestA");
        }
        public TestA(int a)
        {
            Console.WriteLine("TestA with parama");
        }
        static TestA()
        {
            Console.WriteLine("static TestA");
        }
    }
    public  class TestB:TestA
    {
        public TestB():base(2)
        {
            Console.WriteLine("TestB");
        }
        static TestB()
        {
            Console.WriteLine("static TestB");
        }
    }
    public class TestC : TestB
    {
        public TestC()//:base()
        {
            Console.WriteLine("TestC");
        }
        static TestC()
        {
            Console.WriteLine("static TestC");
        }
    }



}
