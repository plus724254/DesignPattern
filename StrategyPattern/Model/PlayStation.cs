using StrategyPattern.Model.GamePad;
using StrategyPattern.Model.LoadGameWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Model
{
    public class PlayStation : GameConsoleAbstract
    {
        public PlayStation()
        {
            this._gamePad = new NormalGamePad();
            this._loadGameWay = new CompactDiscLoadGame();
        }

        public override string Display() => "Sony PlayStation";
    }
}
