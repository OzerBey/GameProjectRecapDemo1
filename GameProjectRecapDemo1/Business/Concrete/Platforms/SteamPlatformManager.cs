﻿using System;
using System.Collections.Generic;
using System.Text;
using GameProjectRecapDemo1.Business.Abstract;
using GameProjectRecapDemo1.Entities.Abstract;

namespace GameProjectRecapDemo1.Business.Concrete.Platforms
{
    class SteamPlatformManager:IPlatformService
    {
        private List<ISalesService> _salesServices;

        public SteamPlatformManager(List<ISalesService> salesServices)
        {
            _salesServices = salesServices;
        }

        public void BuyGame(IEntity person, IEntity game)
        {
            foreach (var sale in _salesServices)
            {
                sale.Discount(game);
            }
            Console.WriteLine(person.Name + "bought " + game.Name + "game from the Steam");
        }

        public void ToRefund(IEntity person, IEntity game)
        {
            Console.WriteLine(person.Name + " returned " + game.Name + " game to the Steam");
        }
    }
}
