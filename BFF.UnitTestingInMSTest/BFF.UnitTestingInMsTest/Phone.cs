using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFF.UnitTestingInMsTest
{
    public class Phone
    {
        public string AlphanumericToPhoneNumber(string phoneword)
        {
            string result = string.Empty;
            foreach (var character in phoneword)
            {
                if ("ABC".Contains(character))
                {
                    result = string.Concat(result, "1");
                }
                else if ("DEF".Contains(character))
                {
                    result = string.Concat(result, "2");
                }
            }
            return result;
        }
    }
}
