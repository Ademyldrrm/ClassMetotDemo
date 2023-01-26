namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "Adem";
            customer1.LastName = "Yıldırım";
            customer1.Id = 1;

            Customer customer2= new Customer();
            customer2.FirstName = "Ahmet";
            customer2.LastName = "Yılmaz";
            customer2.Id = 2;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(customer1);
            customerManager.Ekle(customer2);
            customerManager.Silme(customer1);
            customerManager.Silme(customer2);
            customerManager.Listele(customer1);
            customerManager.Listele(customer2);


        }
    }
}