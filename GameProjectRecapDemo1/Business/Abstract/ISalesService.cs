using System;
using System.Collections.Generic;
using System.Text;
using GameProjectRecapDemo1.Entities.Abstract;

namespace GameProjectRecapDemo1.Business.Abstract
{
    interface ISalesService
    {
        void Discount(IEntity entity);
    }
}
