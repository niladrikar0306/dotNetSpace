
using Org.Niladri.Net.DAL.Bean;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Niladri.Net.DAL.Data
{
    public class RCDataService
    {
        public IList<RCGroupConfig> GetAllDQGroups()
        {
            IList < RCGroupConfig >  li = new List<RCGroupConfig>();

            li = PopulateGroups(li);

            return li;

        }

        private IList<RCGroupConfig> PopulateGroups(IList<RCGroupConfig> li)
        {
            {
                RCGroupConfig gc = new RCGroupConfig(1, "one");
                li.Add(gc);
            }
            {
                RCGroupConfig gc = new RCGroupConfig(2, "two");
                li.Add(gc);
            }
            {
                RCGroupConfig gc = new RCGroupConfig(3, "three");
                li.Add(gc);
            }
            {
                RCGroupConfig gc = new RCGroupConfig(4, "four");
                li.Add(gc);
            }

            return li;
        }

    }
}
