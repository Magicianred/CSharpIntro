using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface newlenemez.

            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());

        }
    }

    interface IPersonManager
    {
        //// Implemented Operation
        //public void Add()
        //{
        //    console.writeline("eklandi");
        //}

        // Unimplemented Operation
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // Müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // Çalışan ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager) // Parametreye dikkat eğer interface olarak verirsek classlar interfaceten implemente olduğu için bu metoda interfaceden implamente olan bütün classları gönderebiliriz.
        {
            personManager.Add();
        }

    }
}
