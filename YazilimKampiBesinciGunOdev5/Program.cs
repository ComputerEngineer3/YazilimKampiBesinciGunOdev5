using System;

namespace YazilimKampiBesinciGunOdev5
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new UserValidationManager());
            customerManager.AddMember(new Customer 
            { 
                Id = 1, 
                IdentityNumber = 12345, 
                FirstName = "FirstName1" , 
                LastName = "LastName1", 
                BirthYear = 1990 
            });

            Console.WriteLine("------------------------------------------------------------------------------");

            customerManager.AddMember(new Customer
            {
                Id = 2,
                IdentityNumber = 12345678910,
                FirstName = "FirstName2",
                LastName = "LastName2",
                BirthYear = 1998
            });

            Console.WriteLine("------------------------------------------------------------------------------");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddNewCampaign( new Campaign 
            { 
                Id=1, 
                CampaignName="Campaign1", 
                DiscountRate=0.2 
            });

            Console.WriteLine("------------------------------------------------------------------------------");

            SaleManager saleManager = new SaleManager(campaignManager);
            saleManager.AddSale(
                new Sale 
                { 
                    Id=1, 
                    CustomerId=1, 
                    CustomerLastName="FirstName1", 
                    soldGameName="Game1", 
                    soldGamePrice=80.00 
                }, 
                new Customer
                {
                Id = 1,
                IdentityNumber = 12345,
                FirstName = "FirstName1",
                LastName = "LastName1",
                BirthYear = 1990
                }, 
                new Campaign
                {
                    Id = 1,
                    CampaignName = "Campaign1",
                    DiscountRate = 0.2
                });

            Console.WriteLine("------------------------------------------------------------------------------");

        }
    }
}
