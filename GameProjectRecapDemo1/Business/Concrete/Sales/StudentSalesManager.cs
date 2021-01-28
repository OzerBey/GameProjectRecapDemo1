﻿using System;
using System.Collections.Generic;
using System.Text;
using GameProjectRecapDemo1.Business.Abstract;
using GameProjectRecapDemo1.Entities.Abstract;

namespace GameProjectRecapDemo1.Business.Concrete.Sales
{
    class StudentSalesManager:ISalesService
    {
        public void Discount(IEntity entity)
        {
            Console.WriteLine("'Student' discount has been made to this product");
        }
    }
}
