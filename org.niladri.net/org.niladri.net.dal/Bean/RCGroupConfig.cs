using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.Niladri.Net.DAL.Bean
{
    public class RCGroupConfig
    {
        public int ID { get; set; }
        public String GROUP_NAME { get; set; }

        public RCGroupConfig(int id, String groupName)
        {
            ID = id;
            GROUP_NAME = groupName;
        }

        public RCGroupConfig()
        {

        }
    }
}
