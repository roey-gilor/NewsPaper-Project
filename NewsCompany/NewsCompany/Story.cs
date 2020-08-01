using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    public class Story
    {
        private string title;
        private string body;
        private string visualStyle;
        public Story()
        {

        }
        public string VisualStyle
        {
            get { return visualStyle; }
            set { visualStyle = value; }
        }

        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public override string ToString()
        {
            return $"Title: {0} Body: {1} Visual style: {2}" + Title + Body + VisualStyle;
        }
    }
}
