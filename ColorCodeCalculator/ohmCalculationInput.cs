using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColorCodeCalculator
{
    public class OhmCalculationInput
    {
        // Color-code dictionary for band A and band B
        public Dictionary<string, int> significantFigures;
        // Color-code dictionary for band C
        public Dictionary<string, int> multiplier;
        // Color-code dictionary for band D
        public Dictionary<string, double> tolerance;

        //Empty Constructor 
        public OhmCalculationInput()
        {
            //Intialize Color-code dictionary for band A and band B
            significantFigures = new Dictionary<string, int> {
                    {"black", 0},
                    {"brown", 1},
                    {"red", 2},
                    {"orange", 3},
                    {"yellow", 4},
                    {"green", 5},
                    {"blue", 6},
                    {"violet", 7},
                    {"gray", 8},
                    {"white", 9}
                };

            // Intialize Color-code dictionary for band C
            multiplier = new Dictionary<string, int> {
                    {"pink", -3},
                    {"silver",  -2},
                    {"gold",  -1},
                    {"black", 0},
                    {"brown", 1},
                    {"red", 2},
                    {"orange",3},
                    {"yellow", 4},
                    {"green", 5},
                    {"blue",  6},
                    {"violet", 7},
                    {"gray", 8},
                    {"white", 9}
            };

            //Intialize Color-code dictionary for band D
            tolerance = new Dictionary<string, double> {
                    {"silver", 0.10},
                    {"gold", 0.05},
                    {"brown",  0.01},
                    {"red", 0.02},
                    {"yellow", 0.05},
                    {"green", 0.005},
                    {"blue", 0.0025},
                    {"violet", 0.001},
                    {"gray", 0.0005}         
            };

        }

    }
}