﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2DBDapper.Table
{
    internal class Orders
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

    }
}
