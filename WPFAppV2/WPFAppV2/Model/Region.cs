using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAppV2.ViewModel;

namespace WPFAppV2.Model
{
    public class Region
    {
        public int ID { get; set; }
        public int CountryID { get; set; }
        public string NameRegion { get; set; }

        public Region() { }

        public Region(int id, int regionId, string nameRegion)
        {
            this.ID = id;
            this.CountryID = regionId;
            this.NameRegion = nameRegion;
        }

        public Region ShallowCopy()
        {
            return (Region)this.MemberwiseClone();
        }

        public Region CopyFromRegionDPO(RegionDPO r)
        {
            CountryViewModel vmCountry = new CountryViewModel();
            int countryId = 0;
            foreach (var c in vmCountry.ListCountry)
            {
                if (c.ShortName == r.Country)
                {
                    countryId = c.ID;
                    break;
                }
            }
            if (countryId != 0)
            {
                this.ID = r.ID;
                this.CountryID = countryId;
                this.NameRegion = r.NameRegion;
            }
            return this;
        }
    }
}
