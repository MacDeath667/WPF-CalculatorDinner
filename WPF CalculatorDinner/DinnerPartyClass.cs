using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_CalculatorDinner
{
    class DinnerParty
    {
        public int NumberOfPeople;
        public int CostOfBeveragesPerPerson;
        public decimal CostOfDecorations;
        public const int CostOfFoodPerPerson = 25;


        public int SetHealthyOption(bool healthy)
        {
            if (healthy)
            {
                CostOfBeveragesPerPerson = 5 * NumberOfPeople; // cost without alco
                return CostOfBeveragesPerPerson;
            }
            CostOfBeveragesPerPerson = 20 * NumberOfPeople; // cost with alco
            return CostOfBeveragesPerPerson;
        }

        public decimal CalculateCostOfDecorations(bool decor)
        {
            if (decor)
            {
                CostOfDecorations = 15 * NumberOfPeople + 50; // cost with decor
                return CostOfDecorations;
            }
            CostOfDecorations = 7.5m * NumberOfPeople + 30; // cost without decor
            return CostOfDecorations;
        }

        public decimal CalculateCost(bool healthy)
        {
            decimal cost = CostOfBeveragesPerPerson+CostOfDecorations+CostOfFoodPerPerson*NumberOfPeople;
            if (healthy)
                cost *= 0.95m;
            return cost;
        }
    }
}
