using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Model.GamePad
{
    public class NormalGamePad : IGamePad
    {
        public string GetGamePadSupport() => "雙人手把";
        public bool CheckGanePadPlayerSupport(int playerAmount) => (playerAmount <= 2);
    }
}
