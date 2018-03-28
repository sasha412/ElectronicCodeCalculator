using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebResistanceCalculator.Models
{
    public class ColorSelectOnLoad
    {
        //color code dictionaries for loading band A & band B select controls 
        public Dictionary<string, string> OhmLoad;
        //color code dictionaries for loading band C select control
        public Dictionary<string, string> MultiplierLoad;
        //color code dictionaries for loading band D select control
        public Dictionary<string, string> ToleranceLoad;

        public ColorSelectOnLoad()
        {
            //intialize band A and band B select control 
            OhmLoad = new Dictionary<string, string> {
                    {"black", "0 Black"},
                    {"brown", "1 brown"},
                    {"red", "2 red"},
                    {"orange", "3 orange"},
                    {"yellow", "4 yellow"},
                    {"green", "5 green"},
                    {"blue", "6 blue"},
                    {"violet", "7 violet"},
                    {"gray", "8 gray"},
                    {"white", "9 white"}
                };

            //intialize band C select control 
            MultiplierLoad = new Dictionary<string, string> {
                    {"pink", "÷1000 Pink"},
                    {"silver", "÷100 Silver"},
                    {"gold", "÷10 Gold"},
                    {"black", "x1 Black"},
                    {"brown", "x10 Brown"},
                    {"red", "x100 Red"},
                    {"orange", "x1k Orange"},
                    {"yellow", "x10k Yellow"},
                    {"green", "x100k Green"},
                    {"blue", "x1M Blue"},
                    {"violet",  "x10M Violet"},
                    {"gray",  "x100M Gray"},
                    {"white", "1G White"}
            };

            //intialize band D select control 
            ToleranceLoad = new Dictionary<string, string> {
                    {"silver",  "± 10% Silver"},
                    {"gold",  "± 5% Gold"},                   
                    {"yellow", "± 4% Yellow"},
                    {"red", "± 2% Red"},
                    {"brown", "± 1% Brown"},
                    {"green", "± 0.5% Green"},
                    {"blue",  "± 0.25% Blue"},
                    {"violet", "± 0.1% Violet"},
                    {"gray", "± 0.05% Gray"}
            };
        }
    }
}