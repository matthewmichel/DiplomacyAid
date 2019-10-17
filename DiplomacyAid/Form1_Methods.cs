using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomacyAid
{
    public partial class Form1
    {
        public void ReloadSeasonAndPhase()
        {
            switch (CurrentSeason)
            {
                case Season.Fall:
                    currentSeason_Lbl.Text = "Fall";
                    redistributionPhase_Btn.Enabled = false;
                    break;
                case Season.Spring:
                    currentSeason_Lbl.Text = "Spring";
                    break;
                default:
                    currentSeason_Lbl.Text = "Error";
                    break;
            }

            switch (CurrentPhase)
            {
                case Phase.BeginningGame:
                    diplomacyPhase_Btn.Enabled = true;
                    orderWritingPhase_Btn.Enabled = false;
                    orderExecutionPhase_Btn.Enabled = false;
                    resultsPhase_Btn.Enabled = false;
                    redistributionPhase_Btn.Enabled = false;

                    // Change current phase label
                    currentPhase_Lbl.Text = "Beginning Game";

                    break;
                case Phase.Diplomacy:
                    if (CurrentSeason == Season.Fall)
                    {
                        CurrentSeason = Season.Spring;
                        currentSeason_Lbl.Text = "Spring";
                    }
                    else
                    {
                        CurrentSeason = Season.Fall;
                        currentSeason_Lbl.Text = "Fall";
                    }

                    diplomacyPhase_Btn.Enabled = false;
                    orderWritingPhase_Btn.Enabled = true;
                    orderExecutionPhase_Btn.Enabled = false;
                    resultsPhase_Btn.Enabled = false;
                    redistributionPhase_Btn.Enabled = false;

                    // Change current phase label
                    currentPhase_Lbl.Text = "Diplomacy";
                    break;
                case Phase.Order_Writing:
                    diplomacyPhase_Btn.Enabled = false;
                    orderWritingPhase_Btn.Enabled = false;
                    orderExecutionPhase_Btn.Enabled = true;
                    resultsPhase_Btn.Enabled = false;
                    redistributionPhase_Btn.Enabled = false;

                    // Change current phase label
                    currentPhase_Lbl.Text = "Order Writing";
                    break;
                case Phase.Order_Execution:
                    diplomacyPhase_Btn.Enabled = false;
                    orderWritingPhase_Btn.Enabled = false;
                    orderExecutionPhase_Btn.Enabled = false;
                    resultsPhase_Btn.Enabled = true;
                    redistributionPhase_Btn.Enabled = false;

                    // Change current phase label
                    currentPhase_Lbl.Text = "Order Execution";
                    break;
                case Phase.Results:
                    if(CurrentSeason == Season.Spring)
                    {
                        diplomacyPhase_Btn.Enabled = false;
                        orderWritingPhase_Btn.Enabled = false;
                        orderExecutionPhase_Btn.Enabled = false;
                        resultsPhase_Btn.Enabled = false;
                        redistributionPhase_Btn.Enabled = true;

                        // Change current phase label
                        currentPhase_Lbl.Text = "Results";
                    } else if (CurrentSeason == Season.Fall)
                    {
                        diplomacyPhase_Btn.Enabled = true;
                        orderWritingPhase_Btn.Enabled = false;
                        orderExecutionPhase_Btn.Enabled = false;
                        resultsPhase_Btn.Enabled = false;
                        redistributionPhase_Btn.Enabled = false;

                        // Change current phase label
                        currentPhase_Lbl.Text = "Results";
                    }
                    
                    break;
                case Phase.Redistribution:
                    diplomacyPhase_Btn.Enabled = true;
                    orderWritingPhase_Btn.Enabled = false;
                    orderExecutionPhase_Btn.Enabled = false;
                    resultsPhase_Btn.Enabled = false;
                    redistributionPhase_Btn.Enabled = false;

                    // Change current phase label
                    currentPhase_Lbl.Text = "Redistribution";
                    break;
                default:
                    diplomacyPhase_Btn.Enabled = false;
                    orderWritingPhase_Btn.Enabled = false;
                    orderExecutionPhase_Btn.Enabled = false;
                    resultsPhase_Btn.Enabled = false;
                    redistributionPhase_Btn.Enabled = false;

                    // Change current phase label
                    currentPhase_Lbl.Text = "ERROR - CHECK SWITCH";
                    break;
            }
        }
    }
}
