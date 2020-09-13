using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Model.LoadGameWay
{
    public class CompactDiscLoadGame : ILoadGameWay
    {
        public string GetLoadGameDetail() => "使用光碟機讀取遊戲";
    }
}
