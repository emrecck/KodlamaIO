using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual individual = new Individual()
            {
                Id = 0 ,
                CustomerNo = "123" ,
                IdentityNo = "22222222222" ,
                Name = "Emre" ,
                SurName = "ÇİÇEK"
            };
            Individual individual1 = new Individual()
            {
                Id = 1 ,
                CustomerNo = "1234" ,
                IdentityNo = "22222222223" ,
                Name = "Yunus" ,
                SurName = "ÇİÇEK"
            };
            Coorporate coorporate = new Coorporate()
            {
                Id = 0 ,
                CustomerNo = "345" ,
                Name = "TürkNet" ,
                TaxNo = "123456789"
            };

            Customer customer2 = new Individual();
            Customer customer3 = new Coorporate();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer2);

        }
    }
}
