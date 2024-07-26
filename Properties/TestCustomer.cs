using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class TestCustomer 
    {
        static void Main()
        {
            Customer obj = new Customer(101, false, "John", 5000.00, cities.Banglore,"Karnataka");
            Console.WriteLine(" Customerid = " +obj.Custid);
            // obj.Custid = 102;        Cant assign value because property is readonly

            if (obj.Status == true)
                Console.WriteLine("Current status is active");
            else
                Console.WriteLine("Current status is In-active");
            Console.WriteLine("Customer name " + obj.Cname);

            obj.Cname = "Abhishek";   // assignement failed so it print old name only

            Console.WriteLine("Customer modified name " + obj.Cname);

            
            Console.WriteLine("Customer Balance " + obj.Balance);
            obj.Balance = 3000;// assignment failed  so old balance is printerd

            Console.WriteLine("Modified Customer Balance " + obj.Balance);

            obj.Status = true;

            if (obj.Status == true)
                Console.WriteLine("Current status is active");
            else
                Console.WriteLine("Current status is In-active");

            obj.Cname = "Abhishek";   // assignement done  new modified name is  printed

            Console.WriteLine("Customer modified name " + obj.Cname);

            obj.Balance-=3000;// assignment Success new balnce printed  

            Console.WriteLine("Modified Customer Balance " + obj.Balance);

            obj.Balance= obj.Balance-1600;  // assignment fails so print old balance only

            Console.WriteLine("Balance when failed " + obj.Balance);

            obj.Balance = obj.Balance - 1400;   // assignment is succed g and it will print new balance

            Console.WriteLine("Balance when succeed  " + obj.Balance);


            
            Console.WriteLine("Current  City " + obj.City);
            obj.City = cities.Heydrabad;


            Console.WriteLine("Current  City " + obj.City);

            Console.WriteLine("Current State " + obj.State);

         //   obj.State = "Telangana"; invalid because current class is not child class of customer
            Console.WriteLine("Modified State " + obj.State);


            Console.WriteLine("Country " + obj.Country);

        
            Console.ReadLine();
    
        }
    }
}
