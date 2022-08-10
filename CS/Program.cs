using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;


namespace CS
{

    abstract class abc
    {
        public abstract void method();

        public virtual void method2()
        {

        }
        public abc()
        {
            method();
        }
    }

    class bcc : abc
    {
        public override void method()
        {
            Console.WriteLine("adad");
        }
    }

    interface IService
    {
        void Display();
    }

    interface IService2 : IService
    {
        string x { get; set; }
        void Display2();
    }

    class One : IService2
    {
        string IService2.x { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Display()
        {
            Console.WriteLine("Display One");
        }

        public void Display2()
        {
            Console.WriteLine("Display Two");
        }
    }

    class Two : IService
    {
        
        public void Display()
        {
            Console.WriteLine("Display Two");
        }
    }

    class Client
    {
        IService iser = null;
        IService2 iser2 = null;
        public Client(IService is1)
        {
            iser = is1;            
        }

        public Client(IService2 is2)
        {
            iser2 = is2;
        }

        public void displaydata()
        {
            iser2.Display();
        }

        public void displaydata2()
        {
            iser2.Display2();
        }
    }


    class LOgText : ILogging
    {
        public void LOg()
        {
            Console.WriteLine("Method Text");
        }
    }

    class DBLOg : ILogging
    {
        public void LOg()
        {
            Console.WriteLine("Method Db");
        }
    }

    public interface ILogging
    {
        void LOg();
    }

    class LogClient
    {
        private ILogging _ilogging;

        public LogClient(ILogging ilogging)
        {
            _ilogging = ilogging;
        }

        public void logCLient()
        {
            _ilogging.LOg();
        }
    }

    class sample
    {
        protected int I;
        public void print()
        {
            Console.WriteLine(I);
        }

        public sample(int a)
        {
            I = a;
        }
    }
    class sample1 : sample
    {
        public int Jas = 0;
        
        public void print()
        {
            Jas = I;
            Console.WriteLine(Jas);
        }

        public sample1(int x) : base(x)
        {

        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<int> i = new List<int> { 4, 3, 5, 1, 2 };
            //int[] arr = new int[] { 1, 1, 1, 0, 1, 1, 0, 0, 0, 0 };
            int[] arr = new int[] { 0, 0 ,1, 0, 0, 1, 1, 0 };
            
            Console.WriteLine(HR_EASY.squares(3,9));
            
            Console.ReadKey();
        }
    }

    public class Customer
    {
        private string _FullName;

        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }

        private DateTime _Dob;

        public DateTime Dob
        {
            get { return _Dob; }
            set { _Dob = value; }
        }

        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

    }

    public class CustomerFluent
    {
        private Customer obj = new Customer();
        public CustomerFluent NameOfCustomer(string Name)
        {
            obj.FullName = Name;
            return this;
        }
        public CustomerFluent Bornon(string Dob)
        {

            obj.Dob = Convert.ToDateTime(Dob);
            return this;
        }

        public void StaysAt(string Address)
        {
            obj.Address = Address;

        }
    }
}
