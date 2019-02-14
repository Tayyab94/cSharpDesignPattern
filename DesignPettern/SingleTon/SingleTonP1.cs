using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPettern.SingleTon
{
    class SingleTonP1
    {
        static void Main1(string[] args)
        {
            Single.myObj().CheckMethod();
         

            string n = Single.myObj().GetNAme();

            Console.WriteLine("your have Entered {0}", n);

            Console.ReadKey();
        }
    }


    sealed class Single
    {
        private Single()
        {

        }

        public static Single GetSingle = null;

        public static Single myObj()
        {
            if(GetSingle==null)
            {
                return new Single();
            }

            return GetSingle;
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
