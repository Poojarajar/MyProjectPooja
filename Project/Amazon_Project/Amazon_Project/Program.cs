namespace Amazon_Project
{
    //Encapsulation
    class Amazon
    {
        string electronic_device1;
        string electronic_device2;
        string brand;
        int count;
        double price;

        static Amazon()//static constructor
        {
            Console.WriteLine("\t\t\tWelcome to Amazon application");
            Console.WriteLine("*********************************");
        }
        public Amazon()//system defined constructor
        {

        }
        //public Amazon()// no argument constructor or default constructor
        //{
        //    Console.WriteLine("hello");
        //}

        public Amazon(string device, int count, string brand)//parameterize constructor
        {
            this.electronic_device1 = device;
            this.count = count;
            this.brand = brand;
        }
        public Amazon(Amazon copys)// copy constructor
        {
            this.electronic_device1 = copys.electronic_device1;
            this.count = copys.count;
            this.brand = copys.brand;
        }
        public void DetailsOfDevice(string electronic_device1, int count, string brand)//no argument method
        {
            Console.WriteLine($"Electronic device Name: {electronic_device1}");
            Console.WriteLine($"Count of the device: {count}");
            Console.WriteLine($"Brand of the device: {brand}");

        }

        public void Bill(double price)// parameterized method
        {
            this.price = price;
            Console.WriteLine($"price of the {electronic_device1} : {price}");

        }
    }









    //Inheritance
    class Electronic_Device : Amazon
    {
        string battery;
        string storage;
        string device_name;

        public Electronic_Device(string device_name)
        {
            this.device_name = device_name;
            Console.WriteLine($"\t\t\tDetails of electronic device {device_name}");
        }
        public void Device_Details(string battery, string storage)
        {
            Console.WriteLine("\t\t\tDevice Details:");
            this.battery = battery;
            this.storage = storage;
            Console.WriteLine($"Battery : {battery}");
            Console.WriteLine($"Device stroage : {storage}");
        }

    }










    //Interface
    interface payment_method
    {
        void Payment_option();

    }

    class Payment : payment_method
    {
        int choice;

        public void Payment_option()
        {
            Console.WriteLine("\t\t\tChoose your payment method:");


            Console.Write("1.cash on delivery\n2. Gpay\n3. Phonepe\n4. Exit");
            Console.WriteLine();
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("\t\t\tCash on delivery is selected!!!");
                        Console.WriteLine("\t\t\tyour order is on the way!!");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\t\t\tGpay is selected!!!");
                        Console.WriteLine("\t\t\tPayment completed");
                        Console.WriteLine("\t\t\tyour order is on the way!!");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\t\t\tPhonepe is selected!!!");
                        Console.WriteLine("\t\t\tPayment completed");
                        Console.WriteLine("\t\t\tyour order is on the way!!");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("\t\t\tRedirecting to main page");
                        Console.WriteLine("\t\t\tyour order is not placed!!");
                        break;
                    }
            }


        }
    }











    //abstraction
    abstract class Offers
    {
        public abstract void off();

        public void Details_Offer()
        {
            Console.WriteLine("\t\t\tOffer details");
            Console.WriteLine("\t\t\tAmazon greate indian sales !!!");
            Console.WriteLine();
        }

    }






    //Polymorphism
    class Discount : Offers
    {

        int bill;
        int disc_rate;

        public override void off()
        {

            Console.WriteLine($"\t\t\tAmazon greate indian saless !!!");
            Console.WriteLine();
        }

        public void discount()
        {
            Console.WriteLine();
        }
        public void discount(int value)
        {
            Console.WriteLine($"\t\t\tyou have {value}% off on this product!!!!!");
        }

        public void discount(int value, int bill)
        {
            this.bill = bill;
            this.disc_rate = value;

            int discount = (bill * value) / 100;
            Console.WriteLine($"\t\t\tyou have saved {discount} amount");
            int price = bill - discount;
            Console.WriteLine($"price : {price}");


        }

    }















    //main class
    class AmazonApplication
    {
        public static void Main(string[] args)
        {
            Amazon device0 = new Amazon();
            Electronic_Device dev1 = new Electronic_Device("laptop");

            dev1.DetailsOfDevice("Laptop", 5, "Dell");
            dev1.Bill(135000);
            dev1.Device_Details("1000mah", "64GB");

            Payment method1 = new Payment();
            Discount disc1 = new Discount();
            disc1.off();
            disc1.Details_Offer();
            disc1.discount();
            disc1.discount(20);
            disc1.discount(20, 135000);
            method1.Payment_option();
            Console.WriteLine();

            Electronic_Device dev2 = new Electronic_Device("mobile");
            dev2.DetailsOfDevice("Mobile", 5, "MI");
            dev2.Bill(60000);
            dev1.Device_Details("5000mah", "128GB");

            Payment method2 = new Payment();
            Discount disc2 = new Discount();
            disc1.off();
            disc1.Details_Offer();
            disc1.discount();
            disc1.discount(5);
            disc1.discount(5, 60000);
            method1.Payment_option();
            Console.WriteLine();

            Electronic_Device dev3 = new Electronic_Device("Tablet");
            dev3.DetailsOfDevice("Tablet", 5, "Samsung");
            dev3.Bill(90000);
            dev1.Device_Details("1000mah", "32GB");
            Payment method3 = new Payment();
            Discount disc3 = new Discount();
            disc1.off();
            disc1.Details_Offer();
            disc1.discount();
            disc1.discount(10);
            disc1.discount(10, 90000);
            method1.Payment_option();



        }
    }
}
