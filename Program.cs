using System;

namespace SampleBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            bool systemControl = true;

            int action;

            Console.WriteLine("Press '1' for customer list\nPress '2' for add customer\nPress '3' for delete customer\nPress '0' for exit in system");
            

            while (systemControl)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi tuşlayınız");
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 0:
                        Console.WriteLine("---İşlemlerden Çıkıldı---");
                        systemControl = false;
                        break;
                    case 1:
                        Console.WriteLine("---Müşteri Listesi--- \n");
                        customerManager.ShowList();
                        break;
                    case 2:
                        Console.WriteLine("---Müşteri Ekle--- \n ");
                        customerManager.CustomerAdd();
                        break;
                    case 3:
                        Console.WriteLine("---Müşteri Sil---");
                        customerManager.CustomerDelete();
                        break;
                    default:
                        Console.WriteLine("!!!Yanlış işlem girişi!!!");
                        break;

                }
            }

            

        }
    }
}
