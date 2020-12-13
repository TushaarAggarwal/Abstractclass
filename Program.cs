using System;

namespace Abstractclass
{

    /*abstract class A
    {
       protected abstract void ABC();    /// Note Protected Abstract method can not Be Accessible
    }*/


    abstract class A
  {
     public abstract void ABC();    /// Note Protected Abstract method can not Be Accessible
  }



    class B : A
    {
        public override  void ABC()
        {
            Console.WriteLine("Abstract Method Definition");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            B ob = new B();
            ob.ABC();
        }
    }
}
