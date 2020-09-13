using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.Model
{
    public class VollyBall : IBallGame
    {
        public string GetName() => "排球";
        public string GetSuggestNumberOfPeople() => "12人";
        public string GetVenueSize() => "286平方公尺";
    }
}
