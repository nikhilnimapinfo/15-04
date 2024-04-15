using System;

namespace Inheritance
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("It IS a copy Method");
        }
        public void Duplicate()
        {
            Console.WriteLine("It is a Duplicate Method");
        }
    }
}
