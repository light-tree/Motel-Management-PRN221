﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Status
{
    public enum InvoiceStatus
    {
        NOT_PAID_YET, PAID, LATE, LATE_AND_NOT_PAID_YET_AND_NOT_INFORMED, LATE_AND_NOT_PAID_YET_AND_INFORMED
    }
}
