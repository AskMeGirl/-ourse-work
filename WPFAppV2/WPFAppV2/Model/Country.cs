using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAppV2.Model
{
    public class Country
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }

        public Country() { }

        public Country(int id, string fullName, string shortName)
        {
            this.ID = id;
            this.FullName = fullName;
            this.ShortName = shortName;
        }

        public Country ShallowCopy()
        {
            return (Country)this.MemberwiseClone();
        }

    }
}
