using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Model.GamePad
{
    public class ExpansionGamePad : IGamePad
    {
        public string GetGamePadSupport() => "四人手把";
        public bool CheckGanePadPlayerSupport(int playerAmount) => (playerAmount <= 4);
    }
}
