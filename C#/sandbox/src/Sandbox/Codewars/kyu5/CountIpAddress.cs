using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Codewars.kyu5
{
    public class CountIpAddress
    {
        // CODEWARS - Count IP Addresses
        // each number can be between 0 - 255
        public static long IpsBetween(string start, string end)
        {
            return _convertIPtoValue(end) - _convertIPtoValue(start);
        }

        private static long _convertIPtoValue(string ip)
        {
            List<long> ipValue = new List<long>(Array.ConvertAll(ip.Split('.'), long.Parse));
            return (ipValue[0] * 256 * 256 * 256) + (ipValue[1] * 256 * 256) + (ipValue[2] * 256) + ipValue[3];
        }
    }
}
