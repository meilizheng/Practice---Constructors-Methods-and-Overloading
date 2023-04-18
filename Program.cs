using System.Security.Principal;
//Meili Zheng;
//4/18/2023;
//Practice___Constructors__Methods__and_Overloading

namespace Practice___Constructors__Methods__and_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car defultCar = new Car();//creat a defult car instance 
            Console.WriteLine(defultCar);//display the information
            Car makeModelCar = new Car("Toyota", "Rav4");//creat a car instance takes two arguments
            Console.WriteLine(makeModelCar);//display information
            Car fullCar = new Car("Hyundai", "Sonata", 2010, 100000);//creat a car instance takes three arguments
            Console.WriteLine(fullCar);//display information

            BankAccount account = new BankAccount("12345", "Will Cram", 20); //creat new bankaccount instance take all arguments
            Console.WriteLine(account); // 12345 - Will Cram - Current Balance: $20.00
            account.Deposit(500);
            Console.WriteLine(account); // 12345 - Will Cram - Current Balance: $520.00
            account.Deposit(-15000);
            Console.WriteLine(account); // 12345 - Will Cram - Current Balance: $520.00
            account.WithDraw(300);
            Console.WriteLine(account); // 12345 - Will Cram - Current Balance: $220.00
            account.WithDraw(-500);
            Console.WriteLine(account); // 12345 - Will Cram - Current Balance: $220.00

        }
    }
}