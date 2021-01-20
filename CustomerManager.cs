using System;
using System.Collections.Generic;
using System.Text;

namespace SampleBank
{
    class CustomerManager
    {
        Customer customer = new Customer();
        List<Customer> Customers = new List<Customer>();
        

        string done = "Customer was created";
        string del = "Customer was deleted";

        public void ShowList()
        {

            foreach (var customer in Customers)
            {
                //Console.WriteLine("ID : " + customer.Id + "\n" + customer.CustomerNameSurname + "\n" + "Tel No : " + customer.TelNo);
                Console.WriteLine("ID : " + customer.Id + "\n" + customer.CustomerNameSurname + "\n");

            }
            Console.WriteLine("#################################################################");
        }


        public void CustomerAdd()
        {
            Console.WriteLine("Enter ID");
            customer.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name and Surname");
            customer.CustomerNameSurname = Console.ReadLine();

            //Console.WriteLine("Enter Age");
            //customer.CustomerAge =int.Parse (Console.ReadLine());

            //Console.WriteLine("Enter Telephone Number");
            //customer.TelNo = Console.ReadLine();

            //Console.WriteLine("Enter Address");
            //customer.Address = Console.ReadLine();

            //Console.WriteLine("Enter Password");
            //customer.Password = int.Parse(Console.ReadLine());

            //Console.WriteLine("Account Amount");
            //customer.Account = double.Parse(Console.ReadLine());

            Customers.Add(customer);

            Console.WriteLine(done);
            Console.WriteLine("********************************************************************");
        }

        public void CustomerDelete()
        {
            Console.WriteLine("Enter ID for delete");

            customer.Id = int.Parse(Console.ReadLine());

            foreach (var customerDelete in Customers)
            {
                if (customerDelete.Id == customer.Id)
                {
                    Console.WriteLine(customer.CustomerNameSurname);
                    Customers.Remove(customerDelete);
                    break;
                }
            }

            Console.WriteLine(del);
            Console.WriteLine("********************************************************************");
        }
    }
}
