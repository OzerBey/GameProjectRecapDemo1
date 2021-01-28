using System;
using System.Collections.Generic;
using System.Text;
using GameProjectRecapDemo1.Entities.Abstract;

namespace GameProjectRecapDemo1.Business.Abstract
{
    interface IPlatformService
    {
        void BuyGame(IEntity person,IEntity game);
        void ToRefund(IEntity person, IEntity game);
    }
}
