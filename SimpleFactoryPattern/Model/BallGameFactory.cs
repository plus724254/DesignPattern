using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.Model
{
    public class BallGameFactory
    {
        public IBallGame CreateBallGame(BallGameType ballGameType)
        {
            return ballGameType switch
            {
                BallGameType.BasketBall => new BasketBall(),
                BallGameType.VollyBall => new VollyBall(),
                BallGameType.Tennis => new Tennis(),
                _ => throw new NotSupportedException("Not support this ballGameType"),
            };
        }
    }
}
