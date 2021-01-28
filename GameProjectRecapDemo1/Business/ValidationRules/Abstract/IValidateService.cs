using System;
using System.Collections.Generic;
using System.Text;
using GameProjectRecapDemo1.Entities.Concrete;

namespace GameProjectRecapDemo1.Business.ValidationRules.Abstract
{
    interface IValidateService
    {
        void Validate(Person person);  
    }
}
