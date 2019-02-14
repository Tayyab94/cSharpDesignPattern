using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPettern.SingleTon
{
    
    class SinglTonp2
    {
        static void Main1(string[] args)
        {
            string n = Single1.Instance.GetNAme();
            Console.WriteLine("your have Entered {0}", n);
            Console.ReadKey();
            string n1 = Single1.Instance.GetNAme();
            Console.WriteLine("your have Entered {0}", n1);
            Console.ReadKey();
        }
    }
    
    sealed class Single1
    {
        public static Single1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Single1();
                }
                return instance;
            }
        }
        private static Single1 instance { get; set; }
        private Single1()
        {

        }
        public void CheckMethod()
        {

            Console.WriteLine("Object is Created now");
        }

        public string GetNAme()
        {
            string name;
            Console.WriteLine("Ener NAme");
            name = Console.ReadLine();
            return name;
        }
    }
}
