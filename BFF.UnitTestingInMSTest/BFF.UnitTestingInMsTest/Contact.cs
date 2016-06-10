using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFF.UnitTestingInMsTest
{
    public class Contact
    {
        public string Name { get; set; }
        public string Notes { get; set; }
        public IList<string> PhoneNumbers { get; set; } = new List<string>();
    }
}
