using SimpleFactoryPattern.Model;
using System;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入球類運動類型 1:籃球 2:排球 3:網球");

            var ballGameType = Enum.Parse<BallGameType>(Console.ReadLine());
            var ballGameFactory = new BallGameFactory();
            var ballGame = ballGameFactory.CreateBallGame(ballGameType);

            Console.WriteLine($"球類名稱 : {ballGame.GetName()}");
            Console.WriteLine($"建議人數 : {ballGame.GetSuggestNumberOfPeople()}");
            Console.WriteLine($"場地需求 : {ballGame.GetVenueSize()}");

            Console.ReadKey();
        }
    }
}
