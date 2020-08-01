using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    public class Newspaper
    {
        private Story[] stories;
        private float price;
        public Newspaper(Story[] stories, float price)
        {
            if (stories[0].VisualStyle == "Red" && stories[1].VisualStyle == "Green" && stories[2].VisualStyle == "Yellow" && stories.Length == 3)
                this.stories = stories;
            else
                Console.WriteLine("Error, you must have at least 3 stories from different teams");
            this.price = price;
        }
        public float Price
        {
            get { return price; }
            set
            {
                if (price > 0)
                    price = value;
                else
                    Console.WriteLine("Price must be bigger than 0");
            }
        }

        public Story[] Stories
        {
            get { return stories; }
            set { stories = value; }
        }
        public override string ToString()
        {
            string st = $"price: {0} " + Price;
            for (int i = 0; i < Stories.Length; i++)
            {
                st += Stories[i].ToString();
            }
            return st;
        }
    }
}
