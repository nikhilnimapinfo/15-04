using System;

namespace Access_Modifier
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating =CalculateRating(Order : true);
            if (rating == 0)
                Console.WriteLine("Promoted to Level 1");
            else
                Console.WriteLine("Promoted to  Level 2");
        }
        protected int CalculateRating(bool Order)
        {
            return 0;
        }
    }
}
