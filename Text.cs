using System;

namespace Inheritance
{
    public class Text : PresentationObject
    {
        public int FontSize{ get; set; }
        public String FontName { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("It is a Url :- " + url);
        }

    }
}
