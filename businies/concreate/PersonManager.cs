using businies.abstrack;
using businies.ServiceReference1;
using entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businies.concreate
{
    public class PersonManager : IAplicantService
    {
        public void AplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            using (ServiceReference1.KPSPublicSoapClient client = new ServiceReference1.KPSPublicSoapClient { })
            {
               bool  durum = client.TCKimlikNoDogrula(person.TcNo, person.ad, person.soyad, person.DogumYili);
            
                return durum;
            }
        }


        public bool CheckPerson(ForeignerManager foreignerManager)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
