using System;
using System.Collections.Generic;
using System.Text;
using GameProjectRecapDemo1.Business.Abstract;
using GameProjectRecapDemo1.Entities.Abstract;

namespace GameProjectRecapDemo1.Business.Concrete.Sales
{
    class GameManager:IEntityService
    {
        public void Add(IEntity game)
        {
            Console.WriteLine(game.Name+" added");
        }

        public void Update(IEntity game)
        {
            Console.WriteLine(game.Name + " updated");

        }

        public void Delete(IEntity game)
        {
            Console.WriteLine(game.Name + " deleted");

        }
    }
}
