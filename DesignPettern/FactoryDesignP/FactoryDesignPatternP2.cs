using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPettern.FactoryDesignP
{
    class FactoryDesignPatternP2
    {
        static void Main1(string[] args)
        {
            var factory = new SavingAccountFacotry() as ICreatedUnionCreatorFactory;

            var city = factory.GetSavingAccount("City-12");

            var national = factory.GetSavingAccount("Natio-12");
            
            Console.WriteLine($"My City Balance is $ {city.Balance}" +
                $"My NAtional Balance is {national.Balance}");
            Console.ReadKey();

        }
       
    }


    //Product


    public abstract class ISavingAccount
    {
        public decimal Balance { get; set; }
    }


    //Concrete Product

    public class CitiSavingAccount:ISavingAccount
    {
        public CitiSavingAccount()
        {
            Balance = 500;
        }
    }

    //Concrete Product

    public class NatiionalSavingAccount : ISavingAccount
    {
        public NatiionalSavingAccount()
        {
            Balance = 5000;
        }
    }


    //Creator

    interface ICreatedUnionCreatorFactory
    {
        ISavingAccount GetSavingAccount(string acctN);
    }


    public class SavingAccountFacotry : ICreatedUnionCreatorFactory
    {
        public ISavingAccount GetSavingAccount(string acctN)
        {
            if (acctN.Contains("City")) { return new CitiSavingAccount(); }
            else
                if (acctN.Contains("Na")) { return new NatiionalSavingAccount(); }
            else
                throw new ArgumentException("Invalid  Account No");
        }
    }
}
