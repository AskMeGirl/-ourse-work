using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAppV2.Model;

namespace WPFAppV2.Helper
{
    class FindAddress
    {
        int id;
        public FindAddress(int id)
        {
            this.id = id;
        }
        public bool AddressPredicate(Address address)
        {
            return address.ID == id;
        }
    }
}
