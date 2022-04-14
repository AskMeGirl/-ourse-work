using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFAppV2.Model;

namespace WPFAppV2.Helper
{
    public class FindCountry
    {
        int id;
        public FindCountry(int id)
        {
            this.id = id;
        }
        public bool CountryPredicate(Country country)
        {
            return country.ID == id;
        }
    }
}
