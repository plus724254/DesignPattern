using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Model.GamePad
{
    public class ExpansionGamePad : IGamePad
    {
        public string GetGamePadSupport() => "四人手把";
    }
}
