using System;

namespace DesignPettern.FactoryDesignP
{
    class FactoryDesignPatternP1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Which Object you want to Call here");
            string t = Console.ReadLine();
            var ob = CreateObj.Getobjects(t);
            ob.SetFirstName();
            ob.SetLastName();
            
            string result = string.Format("{0} {1}", ob.GetFirstName(), ob.GetLastName());

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }


    class CreateObj
    {
        public static IretFunctions Getobjects(string objectType)
        {
            IretFunctions o = null;

            if(objectType.ToLower().Equals("teacher"))
            {
                o = new Teacher();
            }
            else
            {
                o = new Strudent();
            }


            return o;
        }
    }


    public interface IretFunctions
    {
        string GetFirstName();

        string GetLastName();
        void SetFirstName();

        void SetLastName();
    }

    public class Teacher : IretFunctions
    {
        public string firstName { get; set; }

        public string lastName { get; set; }
        public string GetFirstName()
        {
            return string.Format("first Name of the Teahcer is {0}", this.firstName);
        }

        public string GetLastName()
        {
            return string.Format("Last Name of the Teahcer is {0}", this.lastName);
        }

        public void SetFirstName()
        {
            Console.WriteLine("Enter the first Name of the Teacher :");
            this.firstName = Console.ReadLine();
        }

        public void SetLastName()
        {
            Console.WriteLine("Enter the Last Name of the Teacher :");
            this.lastName = Console.ReadLine();
        }
    }

    public class Strudent : IretFunctions
    {
        public string firstName { get; set; }

        public string lastName { get; set; }
        public string GetFirstName()
        {
            return string.Format("first Name of the Student is {0}", this.firstName);
        }

        public string GetLastName()
        {
            return string.Format("Last Name of the Student is {0}", this.lastName);
        }

        public void SetFirstName()
        {
            Console.WriteLine("Enter the first Name of the Student :");
            this.firstName = Console.ReadLine();
        }

        public void SetLastName()
        {
            Console.WriteLine("Enter the Last Name of the Student :");
            this.lastName = Console.ReadLine();
        }
    }
}
