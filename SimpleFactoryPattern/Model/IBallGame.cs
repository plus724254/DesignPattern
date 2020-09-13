using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.Model
{
    public interface IBallGame
    {
        string GetSuggestNumberOfPeople();
        string GetVenueSize();
        string GetName();
    }
}
