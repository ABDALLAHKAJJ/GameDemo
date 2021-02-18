using GameDemo.Entites;
using GameDemo.Objects;
using GameDemo.Concrete;
using GameDemo.Adapter;
using System;

namespace GameDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Game fifa = new FIFA();
            Game pes = new PES();

            Gamer player1 = new Player1();
            Gamer player2 = new Player2()
            {
                Id = 1,
                FirstName = "Abdullah",
                LastName = "NUROĞLU",
                DateOfBirth = new DateTime(1996, 1, 6),
                NationalityNo = "15183075370",
                UserName = "Apo",
                Level = 99
            };

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            bool isValid = gamerManager.Add(player2);

            Campaign campaign = new Campaign()
            {
                Id = 1,
                Name = "free",
                Details = "teke it for free"
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(campaign);
            campaignManager.UpdateCampaign(campaign, "everything for free");
        }
    }
}