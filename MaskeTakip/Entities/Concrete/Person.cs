using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //internal farklı projeden çağrılmasını
    //engeller bu yüzden public ypacağız.
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirtYear { get; set; }

    }
}
