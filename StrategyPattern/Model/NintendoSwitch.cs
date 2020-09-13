using StrategyPattern.Model.GamePad;
using StrategyPattern.Model.LoadGameWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Model
{
    public class NintendoSwitch : GameConsoleAbstract
    {
        public NintendoSwitch()
        {
            this._gamePad = new ExpansionGamePad();
            this._loadGameWay = new CassetteLoadGame();
        }

        public override string Display() => "任天堂Switch";
    }
}
