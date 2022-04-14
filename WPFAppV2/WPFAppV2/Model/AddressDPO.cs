using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAppV2.ViewModel;

namespace WPFAppV2.Model
{
    public class AddressDPO
    {
        public int ID { get; set; }
        public string Person { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string Office { get; set; }

        public AddressDPO() { }

        public AddressDPO(int id, string person, string city, string street, string bilding, string office)
        {
            this.ID = id;
            this.Person = person;
            this.City = city;
            this.Street = street;
            this.Building = bilding;
            this.Office = office;
        }

        public AddressDPO CopyFromAddress(Address address)
        {
            AddressDPO addDPO = new AddressDPO();
            CityViewModel vmCity = new CityViewModel();
            string city = string.Empty;
            foreach (var r in vmCity.ListCity)
            {
                if (r.ID == address.CityID)
                {
                    city = r.NameCity;
                    break;
                }
            }
            if (city != string.Empty)
            {
                addDPO.ID = address.ID;
                addDPO.City = city;
                addDPO.Person = address.Person;
                addDPO.Building = address.Building;
                addDPO.Street = address.Street;
                addDPO.Office = address.Office;
            }
            return addDPO;
        }

        public AddressDPO ShallowCopy()
        {
            return (AddressDPO)this.MemberwiseClone();
        }
    }
}
