using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsCompany;

namespace Store
{
    public class Seller
    {
        private int moneyEarned;

        public int MoneyEarned
        {
            get { return moneyEarned; }
            set { moneyEarned = value; }
        }
        public void SellNewsPaper (Newspaper newspaper)
        {
            MoneyEarned += (int)newspaper.Price;
            Console.WriteLine("Sold");
        }
        public override string ToString()
        {
            return "Money earned " + MoneyEarned;
        }
    }
}
