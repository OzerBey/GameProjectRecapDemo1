using System;
using System.Collections.Generic;
using GameProjectRecapDemo1.Business.Abstract;
using GameProjectRecapDemo1.Business.Concrete;
using GameProjectRecapDemo1.Business.Concrete.Platforms;
using GameProjectRecapDemo1.Business.Concrete.Sales;
using GameProjectRecapDemo1.Entities.Abstract;
using GameProjectRecapDemo1.Entities.Concrete;

namespace GameProjectRecapDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEntityService playerManager = new PlayerManager();
            Person yasin = new Player()
            {
                NationalityIdentity = "12345678901",
                Name = "Yasin",
                LastName = "ÖZer",
                YearOfBirth = 1998,
                Balance =2000
            };
            Person zeynep = new Player()
            {
                NationalityIdentity = "12345678901",
                Name = "Zeynep Nur",
                LastName = "ÖZer",
                YearOfBirth = 2013,
                Balance = 5000
            };
            Person ozer = new Player()
            {
                NationalityIdentity = "12345678901",
                Name = "Ozer",
                LastName = "Yasin",
                YearOfBirth = 1998,
                Balance = 1850.5
            };
            //--operations of persons
            playerManager.Add(yasin);
            playerManager.Add(zeynep);
            playerManager.Add(ozer);

            //operations of games
            IEntity rocketLeague = new Game() {Id = 1,Name = "Rocket League",Publisher = "Psyonix",UnitPrice = 25};
            IEntity gta5 = new Game() { Id = 1, Name = "GTA V", Publisher = "Rockstar Games", UnitPrice = 200 };
            IEntity madMax = new Game() { Id = 1, Name = "Mad Max", Publisher = "Warner Bros. Interactive Entertainment", UnitPrice = 123 };

            IEntityService gameManager = new GameManager();
            gameManager.Add(rocketLeague);
            gameManager.Add(gta5);
            gameManager.Add(madMax);


            //operations of Sales
            ISalesService seasonSale = new SeasonSalesManager();
            ISalesService studenSale = new StudentSalesManager();
            ISalesService summerSale = new SummerSalesManager();
            ISalesService weekendSale = new WeekendSalesManager();
            ISalesService welcomeSale = new WelcomeSalesManager();
            ISalesService winterSale = new WinterSalesManager();

            //platforms
            IPlatformService epicGames = new EpicGamesPlatformManager(new List<ISalesService>() {seasonSale,studenSale,summerSale,weekendSale,winterSale});
            IPlatformService steam = new SteamPlatformManager(new List<ISalesService>() {welcomeSale });

            //game CRUD simulation
            steam.BuyGame(zeynep,gta5);
            steam.ToRefund(zeynep, gta5);
            epicGames.BuyGame(gta5,zeynep);
            epicGames.BuyGame(yasin,rocketLeague);
            steam.ToRefund(ozer,madMax);




        }
    }
}
