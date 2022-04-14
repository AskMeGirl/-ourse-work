using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAppV2.ViewModel;

namespace WPFAppV2.Model
{
    public class City
    {
        public int ID { get; set; }
        public int RegionID { get; set; }
        public string NameCity { get; set; }

        public City() { }

        public City(int id, int regionId, string nameCity)
        {
            this.ID = id;
            this.RegionID = regionId;
            this.NameCity = nameCity;
        }

        public City CopyFromCityDPO(CityDPO p)
        {
            RegionViewModel vmRegion = new RegionViewModel();
            int regionId = 0;
            foreach (var r in vmRegion.ListRegion)
            {
                if (r.NameRegion == p.Region)
                {
                    regionId = r.ID;
                    break;
                }
            }
            if (regionId != 0)
            {
                this.ID = p.ID;
                this.RegionID = regionId;
                this.NameCity = p.NameCity;
            }
            return this;
        }

        public City ShallowCopy()
        {
            return (City)this.MemberwiseClone();
        }
    }
}
