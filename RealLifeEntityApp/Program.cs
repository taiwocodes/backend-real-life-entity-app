using System;

namespace RealLifeEntityApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Phone phone = new Phone
            {
                Brand = "iPhone",
                Model = "XR",
                Color = "Black",
                Size = "15 inches",
                RAM = "8gb",
                ROM = "64gb",
        };

            Console.WriteLine(phone.Print());
        }
    }
}
