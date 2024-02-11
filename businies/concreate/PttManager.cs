using businies.abstrack;
using entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businies.concreate
{
    public class PttManager : IsuplierService
    {
        IAplicantService _aplicantService;
        public PttManager(IAplicantService aplicantService)
        {
            _aplicantService = aplicantService;
        }
        public void GiveMask(Person person)
        {
          ;
            if (_aplicantService.CheckPerson(person) )
            {
                Console.WriteLine( person.ad + " maske verildi");
            }
            else
            {
                Console.WriteLine(person.ad + " maske verilmedi");
            }
        }
    }
}
