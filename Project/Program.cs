using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Melek";
            customer1.LastName = "Battal";
            customer1.TcNo = "30967569678";
            customer1.City = "İstanbul";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Sinan";
            customer2.LastName = "Kaya";
            customer2.TcNo = "12345678";
            customer2.City = "Sivas";
            Console.WriteLine(customer2.FirstName);

        }


    }
        class Customer
    {

        public Customer()
        {
            Console.WriteLine("Yapıcı blok Çalıştı");
            
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public string City { get; set; }
    }
}
