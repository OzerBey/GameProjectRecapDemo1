using System;
using System.Collections.Generic;
using System.Text;
using GameProjectRecapDemo1.Business.Abstract;
using GameProjectRecapDemo1.Entities.Abstract;

namespace GameProjectRecapDemo1.Business.Concrete
{
    class PlayerManager:IEntityService
    {

        public void Add(IEntity person)
        {
            Console.WriteLine(person.Name+ " added");
        }

        public void Update(IEntity person)
        {
            Console.WriteLine(person.Name+ " updated");
        }

        public void Delete(IEntity person)
        {
            Console.WriteLine(person.Name+" deleted");
        }
    }
}
