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
            this.TestA(12);
        }
        public TestA(int a)
        {
            Console.WriteLine("TestA with parama");
        }

        public void a()
        {
            
        }
        static TestA()
        {
            Console.WriteLine("static TestA");
        }

        public static int MyProperty { get; set; }
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

    public class ConstructorTesting
    {
        public ConstructorTesting(): this(10)
        {
            ;
        }

        public ConstructorTesting(int a)
        {

        }
    }



}
