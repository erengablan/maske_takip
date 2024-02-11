using businies.concreate;
using entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businies.abstrack
{
    public interface IAplicantService
    {
        void AplyForMask(Person person);
        
        List<Person> GetList();


        bool CheckPerson(Person person);
        bool CheckPerson(ForeignerManager foreignerManager);
    }
}
