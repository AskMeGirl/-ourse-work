using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAppV2.ViewModel;

namespace WPFAppV2.Model
{
    public class RegionDPO
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string NameRegion { get; set; }

        public RegionDPO() { }

        public RegionDPO(int id, string country, string nameRegion)
        {
            this.ID = id;
            this.Country = country;
            this.NameRegion = nameRegion;
        }

        public RegionDPO CopyFromRegion(Region region)
        {
            RegionDPO RegDPO = new RegionDPO();
            CountryViewModel vmCountry = new CountryViewModel();
            string country = string.Empty;
            foreach (var r in vmCountry.ListCountry)
            {
                if (r.ID == region.CountryID)
                {
                    country = r.ShortName;
                    break;
                }
            }
            if (country != string.Empty)
            {
                RegDPO.ID = region.ID;
                RegDPO.Country = country;
                RegDPO.NameRegion = region.NameRegion;
            }
            return RegDPO;
        }

        public RegionDPO ShallowCopy()
        {
            return (RegionDPO)this.MemberwiseClone();
        }
    }
}
