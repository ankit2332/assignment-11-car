using System;

namespace assignment_11_car
{
    class Program
    {
        static void Main(string[] args)
        {
            car mycar = new car("red", "benz", 2960, 600); 

            passenger driver = new passenger("ankit");
            passenger shotgun = new passenger("prem");

            mycar.driver = driver;
            Console.WriteLine(mycar.driver.name);

        }
    }
}
