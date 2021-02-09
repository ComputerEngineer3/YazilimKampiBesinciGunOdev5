using System;
using System.Collections.Generic;
using System.Text;

namespace YazilimKampiBesinciGunOdev5
{
    class SaleManager : ISaleService
    {
        ICampaignService _campaignService;

        public SaleManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void AddSale(Sale sale, Customer customer, Campaign campaign)
        {
            double gamePrice = sale.soldGamePrice;
            double campaignRate = _campaignService.CalculateCampaignRate(campaign);
            double totalPrice = gamePrice - gamePrice * campaignRate;

            Console.WriteLine("Satış oluşturuldu : ");
            Console.WriteLine("Müşteri: " + customer.FirstName + " " + customer.LastName);
            Console.WriteLine("Satılan oyunun ismi: " + sale.soldGameName);
            Console.WriteLine("Satılan oyunun fiyatı: " + sale.soldGamePrice);
            Console.WriteLine("Satılan oyunun indirim uygulandıktan sonraki fiyatı: " + totalPrice);
        }

        public void CancelSale(Sale sale, Customer customer, Campaign campaign)
        {
            Console.WriteLine("Satış iptal edildi.");
        }

        public void UpdateSale(Sale sale, Customer customer, Campaign campaign)
        {
            Console.WriteLine("Satış güncellendi.");
        }
    }
}
