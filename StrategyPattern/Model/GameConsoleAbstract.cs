using StrategyPattern.Model.GamePad;
using StrategyPattern.Model.LoadGameWay;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Model
{
    public abstract class GameConsoleAbstract
    {
        protected ILoadGameWay _loadGameWay;
        protected IGamePad _gamePad;

        public abstract string Display();

        public string GetLoadGameWay()
        {
            return _loadGameWay.GetLoadGameDetail();
        }

        public string GetGamepadSupport()
        {
            return _gamePad.GetGamePadSupport();
        }

        public void SetLoadGameWay(ILoadGameWay loadGameWay)
        {
            this._loadGameWay = loadGameWay;
        }

        public void SetGamePadTool(IGamePad gamePad)
        {
            this._gamePad = gamePad;
        }

    }
}
