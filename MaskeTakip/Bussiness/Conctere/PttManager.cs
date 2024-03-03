using Bussiness.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Conctere
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicationService;
        public PttManager(IApplicantService applicationService)
        {
            _applicationService = applicationService;
        }
        public void GiveMask(Person person)
        {
            //Bir class başka bir classı kullanmak için new liyorsa o classa bağımlıdır demektir. B ubağımlılık kod değişimine direnç göstereceği anlamına gelir.
            //PersonManager personManager = new PersonManager();
            if (_applicationService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " " + "için maske verildi");
            }
        }
    }
}
