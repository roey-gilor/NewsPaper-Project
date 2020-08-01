using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    internal class PoliticsTeam : NewsTeam
    {
        public override string ToString()
        {
            return base.ToString();
        }

        internal override void AddStyle()
        {
            story.VisualStyle = "Red";
        }

        internal override void CreateStory()
        {
            story.Title = "Politics story";
            story.Body = "Something intresting about politics";
        }

    }
}
