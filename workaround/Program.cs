using businies.concreate;
using entities.Concreate;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.ad = "eren";
            person1.soyad = "gablan";
            person1.TcNo = 33526681330;
            person1.DogumYili = 2002;
            PttManager pttMamager=new PttManager(new PersonManager());
            pttMamager.GiveMask(person1);

        }
        
    }
}
