using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Model.GamePad
{
    public class PortableGamePad : IGamePad
    {
        public string GetGamePadSupport() => "單人手把";
        public bool CheckGanePadPlayerSupport(int playerAmount) => (playerAmount <= 1);
    }
}
