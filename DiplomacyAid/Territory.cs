using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomacyAid
{
    class Territory
    {
        string[] borderTerr = {};
        bool supplyPoint;
        bool isCapitol;
        bool isCoast;

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
