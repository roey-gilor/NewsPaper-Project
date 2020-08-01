using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    internal abstract class NewsTeam
    {
        protected Story story;

        internal Story Story
        {
            get { return story; }
        }
        internal abstract void CreateStory();
        internal virtual void AddStyle()
        {
            story.VisualStyle = "White";
        }
        public override string ToString()
        {
            return $"Story: {0} Style: {1} Title: {2}" + story.Body + story.VisualStyle + story.Title;
        }
    }
}
