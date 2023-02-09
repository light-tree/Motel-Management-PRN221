﻿using BussinessObject.Status;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Models
{
    public class MotelChain
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public MotelChainStatus Status { get; set; }
        public long? ManagerId { get; set; }

        [ForeignKey("Id")]
        public Manager Manager { get; set; }
        public virtual List<Room> Rooms { get; set; }
    }
}
