using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFAppV2.Model;

namespace WPFAppV2.Helper
{
    public class FindRegion
    {
        int id;
        public FindRegion(int id)
        {
            this.id = id;
        }
        public bool RegionPredicate(Region region)
        {
            return region.ID == id;
        }
    }
}
