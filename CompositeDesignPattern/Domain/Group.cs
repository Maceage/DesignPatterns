using System.Collections.Generic;
using System.Linq;

namespace CompositePattern.Domain
{
    public class Group : IParty
    {
        public Group()
        {
            Members = new List<IParty>();
        }

        public string Name { get; set; }
        public List<IParty> Members { get; set; }

        public int Gold
        {
            get
            {
                return Members.Sum(member => member.Gold);
            }

            set
            {
                var eachSplit = value / Members.Count;
                var leftOver = value % Members.Count;

                foreach (var member in Members)
                {
                    member.Gold += (eachSplit + leftOver);
                    leftOver = 0;
                }
            }
        }

        public void Stats()
        {
            foreach (var member in Members)
            {
                member.Stats();
            }
        }
    }
}