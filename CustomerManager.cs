using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Ekle(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi : "+customer.LastName);
        }

        public void Silme(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi : " + customer.FirstName);
        }

        public void Listele(Customer customer)
        {
            Console.WriteLine("Id listelendi : " + customer.Id);
        }

    }
}
