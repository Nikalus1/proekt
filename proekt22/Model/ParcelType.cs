﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt22
{
    public class ParcelType
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public ICollection<Parcel> Parcels { get; set; }
    }
}
