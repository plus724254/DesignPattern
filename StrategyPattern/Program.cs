using StrategyPattern.Model;
using StrategyPattern.Model.GamePad;
using StrategyPattern.Model.LoadGameWay;
using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入玩家人數");
            var playerAmount = Convert.ToInt32(Console.ReadLine());

            var playStation = new PlayStation();
            var nintendoSwitch = new NintendoSwitch();

            var gameConsoles = new List<GameConsoleAbstract>()
            {
                playStation,
                nintendoSwitch,
            };

            gameConsoles.ForEach(x => ShowDetail(x, playerAmount));

            Console.WriteLine("將PS插入手把擴充器，連接網路讀取遊戲\n");

            playStation.SetGamePadTool(new ExpansionGamePad());
            playStation.SetLoadGameWay(new NetworkLoadGame());

            ShowDetail(playStation, playerAmount);

            Console.WriteLine("將NS連接網路讀取遊戲\n");
            nintendoSwitch.SetLoadGameWay(new NetworkLoadGame());

            ShowDetail(nintendoSwitch, playerAmount);

            Console.ReadKey();
        }

        private static void ShowDetail(GameConsoleAbstract gameConsole, int playerAmount)
        {
            Console.WriteLine($"遊戲主機: {gameConsole.Display()}");
            Console.WriteLine($"支援手把數量 : {gameConsole.GetGamepadSupport()}");
            Console.WriteLine($"是否支援{playerAmount}人遊玩 : "+ (gameConsole.GetGamepadPlayerSupport(playerAmount)?"是":"否"));
            Console.WriteLine($"目前遊戲讀取方式 : {gameConsole.GetLoadGameWay()}\n");
        }
    }
}
