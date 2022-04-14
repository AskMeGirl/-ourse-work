using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAppV2.ViewModel;

namespace WPFAppV2.Model
{
    public class CityDPO
    {
        public int ID { get; set; }
        public string Region { get; set; }
        public string NameCity { get; set; }

        public CityDPO() { }

        public CityDPO(int id, string region, string nameCity)
        {
            this.ID = id;
            this.Region = region;
            this.NameCity = nameCity;
        }

        public CityDPO CopyFromCity(City city)
        {
            CityDPO RegDPO = new CityDPO();
            RegionViewModel vmRegion = new RegionViewModel();
            string region = string.Empty;
            foreach (var r in vmRegion.ListRegion)
            {
                if (r.ID == city.RegionID)
                {
                    region = r.NameRegion;
                    break;
                }
            }
            if (region != string.Empty)
            {
                RegDPO.ID = city.ID;
                RegDPO.Region = region;
                RegDPO.NameCity = city.NameCity;
            }
            return RegDPO;
        }

        public CityDPO ShallowCopy()
        {
            return (CityDPO)this.MemberwiseClone();
        }
    }
}
