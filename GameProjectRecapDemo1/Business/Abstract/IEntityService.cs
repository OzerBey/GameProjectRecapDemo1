using System;
using System.Collections.Generic;
using System.Text;
using GameProjectRecapDemo1.Entities.Abstract;

namespace GameProjectRecapDemo1.Business.Abstract
{
    interface IEntityService
    {
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity); 

    }
}
