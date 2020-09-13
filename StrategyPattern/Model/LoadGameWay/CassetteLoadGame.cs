using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Model.LoadGameWay
{
    public class CassetteLoadGame : ILoadGameWay
    {
        public string GetLoadGameDetail() => "使用卡匣讀取遊戲";
    }
}
