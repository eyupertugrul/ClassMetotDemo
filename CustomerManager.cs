using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.MusteriAdi + " " +customer.MusteriSoyadi+ " " + customer.Sehir + " " + "Eklendi");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.MusteriAdi+" " + customer.MusteriSoyadi+" "+customer.Sehir+" "+"Silindi");
        }
        public void Listele(Customer customer)
        {
            Console.WriteLine(customer.MusteriAdi+" "+customer.MusteriSoyadi+" "+customer.Sehir);
        }
    }
}
