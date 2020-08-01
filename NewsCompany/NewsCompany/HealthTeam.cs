using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    internal class HealthTeam : NewsTeam
    {
        public override string ToString()
        {
            return base.ToString();
        }

        internal override void AddStyle()
        {
            story.VisualStyle = "Green";
        }

        internal override void CreateStory()
        {
            story.Title = "Health story";
            story.Body = "Something intresting about health";
        }
    }
}
