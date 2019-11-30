using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomacyAid
{
    class Order
    {
        private string _troopFromName;
        private OrderActions _orderAction;
        private string _territoryToName;
        private string _orderName;

        public Order(string troopFromName, OrderActions orderAction, string territoryToName, string orderName)
        {

        }

        public Order(string troopFromName, string orderAction, string territoryToName, string orderName)
        {
            TroopFromName = troopFromName;

            if (orderAction == "attack")
            {
                OrderAction = OrderActions.Attack;
            }
            else if (orderAction == "support")
            {
                OrderAction = OrderActions.Support;
            } else if (orderAction == "convoy")
            {
                OrderAction = OrderActions.Convoy;
            }  else
            {
                OrderAction = OrderActions.Hold;
            }

            TerritoryToName = territoryToName;
            OrderName = orderName;
        }

        public string TroopFromName
        {
            get
            {
                return _troopFromName;
            }
            set
            {
                _troopFromName = value;
            }
        }

        public OrderActions OrderAction
        {
            get
            {
                return _orderAction;
            }
            set
            {
                _orderAction = value;
            }
        }

        public string TerritoryToName
        {
            get
            {
                return _territoryToName;
            }
            set
            {
                _territoryToName = value;
            }
        }

        public string OrderName
        {
            get
            {
                return _orderName;
            }
            set
            {
                _orderName = value;
            }
        }

        
    }

    enum OrderActions
    {
        Attack,
        Support,
        Convoy,
        Hold
    }
}
