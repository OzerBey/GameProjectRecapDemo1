using System;
using System.Collections.Generic;
using System.Text;
using GameProjectRecapDemo1.Entities.Abstract;

namespace GameProjectRecapDemo1.Entities.Concrete
{
    class Person : IEntity
    {
        public string NationalityIdentity { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }


    }
}
