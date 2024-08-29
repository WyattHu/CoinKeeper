using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoinKeeper
{
    [XmlInclude(typeof(UserInfo))]
    public class UserInfo
    {
        public List<string> tokenAddress;
        public List<string> transactionHash;

        public UserInfo() 
        { 
            tokenAddress = new List<string>();
            transactionHash = new List<string>();
        }
    }
}
