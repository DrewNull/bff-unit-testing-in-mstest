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
                    result = string.Concat(result, "2");
                }
                else if ("DEF".Contains(character))
                {
                    result = string.Concat(result, "3");
                }
                else if ("GHI".Contains(character))
                {
                    result = string.Concat(result, "4");
                }
                else if ("JKL".Contains(character))
                {
                    result = string.Concat(result, "5");
                }
                else if ("MNO".Contains(character))
                {
                    result = string.Concat(result, "6");
                }
                else if ("PQRS".Contains(character))
                {
                    result = string.Concat(result, "7");
                }
                else if ("TUV".Contains(character))
                {
                    result = string.Concat(result, "8");
                }
                else if ("WXYZ".Contains(character))
                {
                    result = string.Concat(result, "9");
                }
                else if ("-()".Contains(character))
                {
                    // skip
                }
                else if ("1234567890".Contains(character))
                {
                    result = string.Concat(result, character);
                }
            }
            return result;
        }
    }
}
