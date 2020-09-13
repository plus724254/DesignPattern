using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.Model
{
    public class BasketBall : IBallGame
    {
        public string GetName() => "籃球";
        public string GetSuggestNumberOfPeople() => "2~10人";
        public string GetVenueSize() => "420平方公尺";
    }
}
