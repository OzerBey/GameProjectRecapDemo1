using System;
using System.Collections.Generic;
using System.Text;
using GameProjectRecapDemo1.Entities.Concrete;

namespace GameProjectRecapDemo1.Business.ValidationRules.Abstract.Concrete
{
    class MernisValidateService:IValidateService
    {
        public void Validate(Person person)
        {
            if (person.Name.Length > 1 && person.LastName.Length > 1 && person.NationalityIdentity.Length == 11 && person.YearOfBirth > 1800)
            {
                Console.WriteLine(person.Name + " " + person.LastName + " successful validation");
            }
            else
            {
                Console.WriteLine(person.Name + " " + person.LastName + " unsuccessful validation !");

            }
        }
    }
}
