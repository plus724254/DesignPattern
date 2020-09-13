using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Model.LoadGameWay
{
    public class NetworkLoadGame : ILoadGameWay
    {
        public string GetLoadGameDetail() => "使用網路雲端讀取遊戲";
    }
}
