﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Stok
    {
        public int Id { get; set; }

        public int UrunlerId { get; set; }

        public int Adet { get; set; }
        public bool Durum { get; set; }
    }
}