using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    internal class GossipTeam: NewsTeam
    {
        public override string ToString()
        {
            return base.ToString();
        }

        internal override void AddStyle()
        {
            story.VisualStyle = "Yellow";
        }

        internal override void CreateStory()
        {
            story.Title = "Gossip story";
            story.Body = "Something intresting about gossips";
        }
    }
}
