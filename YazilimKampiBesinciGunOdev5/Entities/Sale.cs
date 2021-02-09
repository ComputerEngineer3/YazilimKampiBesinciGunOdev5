using System;
using System.Collections.Generic;
using System.Text;

namespace YazilimKampiBesinciGunOdev5
{
    class Sale
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CustomerLastName { get; set; }
        public string soldGameName { get; set; }
        public double soldGamePrice { get; set; }
    }
}
