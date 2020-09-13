using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.Model
{
    public class Tennis : IBallGame
    {
        public string GetName() => "網球";
        public string GetSuggestNumberOfPeople() => "2~4人";
        public string GetVenueSize() => "1,000平方公尺";
    }
}
