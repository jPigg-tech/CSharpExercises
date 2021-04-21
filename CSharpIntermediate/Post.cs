using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class Post
    {
        public string Title { get; set; }
        public string  Description { get; set; }
        public DateTime DateCreated { get; set; }
        private List<int> Votes = new List<int>();

        public void VoteUp()
        {
            Votes.Add(1);
        }

        public void VoteDown()
        {
            Votes.Remove(1);
        }


    }
}
