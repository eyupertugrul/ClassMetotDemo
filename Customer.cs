using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Customer
    {
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string Sehir { get; set; }

        internal void Listele(Customer customer1)
        {
            throw new NotImplementedException();
        }
    }
}
