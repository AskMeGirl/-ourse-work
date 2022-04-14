using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFAppV2.Model;

namespace WPFAppV2.Helper
{
    public class FindCity
    {
        int id;
        public FindCity(int id)
        {
            this.id = id;
        }
        public bool CityPredicate(City city)
        {
            return city.ID == id;
        }
    }
}
