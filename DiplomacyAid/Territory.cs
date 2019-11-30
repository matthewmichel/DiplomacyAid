using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomacyAid
{
    class Territory
    {
        public int[] BorderTerr;
        public bool SupplyPoint;
        public bool IsCapitol;
        public bool IsCoast;
        public string TerritoryName;
        public int TerritoryId;

        public Territory(int territoryId, string name, bool isCapitol, bool isCoast, bool isSupplyPoint, int[] borderTerr)
        {
            TerritoryId = territoryId;
            TerritoryName = name;
            IsCapitol = isCapitol;
            IsCoast = isCoast;
            SupplyPoint = isSupplyPoint;
            BorderTerr = borderTerr;
        }

        Troop occupyingTroop;
        Country motherCountry;

    }

    enum terType
    {
        land,
        sea,
        coast
    }
}
