using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPettern.SingleTon
{
    class SingleTonP3
    {
        static void Main(string[] args)
        {
            var obj = tay.Instance.GetName();
            Console.WriteLine("Name is :{0}", obj);


            string na = tay.Instance.GetName();

            Console.WriteLine("Na :{0}", na);

            Console.ReadKey();
        }
    }

    public class tay
    {
        private static tay _instance { get; set; }

        public static tay Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new tay();
                return _instance;
            }
        }
        public tay()
        {

        }

        public string GetName()
        {
            return "Tayyab";
        }








        //private static readonly object _lock = new object();
        //private static tay _instance { get; set; }

        //public static tay Instance
        //{
        //    get
        //    {
        //        lock (_lock)
        //        {

        //            if (_instance == null)
        //                _instance = new tay();

        //            return _instance;
        //        }
        //    }
        //}
    }
}
