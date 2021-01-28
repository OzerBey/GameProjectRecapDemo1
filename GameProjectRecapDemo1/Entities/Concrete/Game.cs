using System;
using System.Collections.Generic;
using System.Text;
using GameProjectRecapDemo1.Entities.Abstract;

namespace GameProjectRecapDemo1.Entities.Concrete
{
    class Game :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public double UnitPrice { get; set; }

    }
}
