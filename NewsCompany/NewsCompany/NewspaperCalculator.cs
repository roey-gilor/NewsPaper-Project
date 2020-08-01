using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    internal static class NewspaperCalculator
    {
        internal static int CalcNumberOfChars (Newspaper newspaper)
        {
            int numberOfChars = 0;
            Story[] stories = newspaper.Stories;
            foreach (var item in stories)
            {
                numberOfChars += item.Body.Length;
            }
            return numberOfChars;
        }
    }
}
