using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { MusteriAdi = "Eyüp", MusteriSoyadi = "Kılıç", Sehir = "İstanbul" };
            Customer customer2 = new Customer { MusteriAdi = "Ertuğrul", MusteriSoyadi = "Yiğit", Sehir = "Hatay" };

            Customer[] customers = new Customer[] { customer1, customer2 };
            CustomerManager customerManager = new CustomerManager();
            
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            Console.WriteLine("-----------");

            foreach (var customer in customers)
            {
                customer.Listele(customer1);
            }
            Console.WriteLine("----------");

            customerManager.Delete(customer2);

        }
    }
}
