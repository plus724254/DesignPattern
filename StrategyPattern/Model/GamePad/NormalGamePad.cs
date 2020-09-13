using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Model.GamePad
{
    public class NormalGamePad : IGamePad
    {
        public string GetGamePadSupport() => "雙人手把";
    }
}
