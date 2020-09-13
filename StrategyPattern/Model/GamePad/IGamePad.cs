using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Model.GamePad
{
    public interface IGamePad
    {
        string GetGamePadSupport();
        bool CheckGanePadPlayerSupport(int playerAmount);
    }
}
