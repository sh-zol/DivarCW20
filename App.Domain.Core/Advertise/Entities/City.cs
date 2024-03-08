﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Advertise.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Advertise> CityAdvertises { get; set; }
    }
}
