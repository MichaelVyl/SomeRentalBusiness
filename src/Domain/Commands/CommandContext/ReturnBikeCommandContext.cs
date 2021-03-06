﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Commands.CommandContext
{
    public class ReturnBikeCommandContext : ICommandContext
    {
        public Bike Bike { get; set; }
        public RentPoint RentPoint { get; set; }
        public bool IsBroken { get; set; }
    }
}
