using Bussiness.Abstract;
using Entities.Concrete;
using MenrisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Conctere
{   //Çıplak clss kalmasın
    public class PersonManager : IApplicantService
    {
        //Özellikleri alıp bir classın içine koymaya encapsulation adı verilir.
        public void ApplyForMask(Person person)
        {

        }
        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(123,"İbrahim","Güneş",1983))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
