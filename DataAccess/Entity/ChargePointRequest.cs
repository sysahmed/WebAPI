﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class ChargePointRequest : BaseEntity
    {
        public List<ChargePoint> chargePoints { get; set; }
    }
}
