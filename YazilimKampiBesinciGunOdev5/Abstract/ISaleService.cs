using System;
using System.Collections.Generic;
using System.Text;

namespace YazilimKampiBesinciGunOdev5
{
    interface ISaleService
    {
        void AddSale(Sale sale, Customer customer, Campaign compaign);
        void UpdateSale(Sale sale, Customer customer, Campaign compaign);
        void CancelSale(Sale sale, Customer customer, Campaign compaign);
    }
}
