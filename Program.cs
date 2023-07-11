using GameProjectSimulation.Concrete;
using GameProjectSimulation.Entities;

namespace GameProjectSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Gereksinimler

                1.     Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)

                2.     Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

                3.     Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

                4.     Satışlarda kampanya entegrasyonunu simule ediniz.
            */


            GamerManager gamerManager = new GamerManager();
            Gamer gamer1 = new Gamer()
            {
                GamerId = 1,
                GamerName = "Muaz Erdem",
                GamerLastName = "Yiğit",
                DateOfBirth = new DateTime(1999, 9, 21),
                NationalityId = "11111111111"
            };
            gamerManager.Add(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);

            Console.WriteLine("-------------------");

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign()
            {
                CampaignId = 1,
                CampaignName = "Simulation Campaign",
                CampaignPercentage = 7.8f
            };
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            Console.WriteLine("-------------------");

            GameManager gameManager = new GameManager();
            Game game1 = new Game()
            {
                GameId = 1,
                GameName = "Game Project Simulation",
                GamePrice = 150
            };
            gameManager.Add(game1);
            gameManager.Update(game1);
            gameManager.Delete(game1);
            gameManager.SellGame(game1, gamer1, campaign);
        }
    }
}