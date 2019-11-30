using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomacyAid
{
    class Troop
    {
        private Territory _occupyingTerritory;
        TroopType troopType;



        public Territory OccupyingTerritory
        {
            get
            {
                return _occupyingTerritory;
            }
            set
            {
                _occupyingTerritory = value;
            }
        }

    }

    enum TroopType
    {
        Army,
        Boat
    }
}
