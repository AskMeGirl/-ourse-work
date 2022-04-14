using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAppV2.ViewModel;

namespace WPFAppV2.Model
{
    public class Address
    {
        public int ID { get; set; }
        public string Person { get; set; }
        public int CityID { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string Office { get; set; }

        public Address() { }

        public Address(int id, string person, int cityId, string street, string bilding, string office)
        {
            this.ID = id;
            this.Person = person;
            this.CityID = cityId;
            this.Street = street;
            this.Building = bilding;
            this.Office = office;
        }

        public Address CopyFromAddressDPO(AddressDPO p)
        {
            CityViewModel vmCity = new CityViewModel();
            int cityId = 0;
            foreach (var r in vmCity.ListCity)
            {
                if (r.NameCity == p.City)
                {
                    cityId = r.ID;
                    break;
                }
            }
            if (cityId != 0)
            {
                this.ID = p.ID;
                this.CityID = cityId;
                this.Building = p.Building;
                this.Street = p.Street;
                this.Person = p.Person;
                this.Office = p.Office;
            }
            return this;
        }

        public Address ShallowCopy()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}
