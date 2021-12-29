using System;

namespace RealLifeEntityApp
{
    public class Phone
    {
        public string Brand { get; set; }
        public  string Model { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string RAM { get; set; }
        public string ROM { get; set; }

        //methods
        public string GetPhoneType()
        {
            return Brand + " " + Model;
        }

        private string GetPhoneMemory()
        {
            return ROM;
        }

        public string GetPhoneSpace()
        {
            return RAM;
        }

        public string Print()
        {
                return "I use a " + Color + " " + GetPhoneType() + " which is " + Size + " and has a RAM of " + RAM + " with "  + GetPhoneSpace() + " storage space.";
        }
    }
}