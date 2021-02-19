using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1991,
                FirstName = "MELEK",
                LastName = "BATTAL",
                NationalityId = 1234
            });
            Console.WriteLine("Hello World!");
            CampaignManager campaignmanager = new CampaignManager ();
            campaignmanager.Add(new Campaign
            {
                Id=2,NameOfCampaign= "New Player Campaign"
            });

        }
    }
}
