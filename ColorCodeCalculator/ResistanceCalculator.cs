using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCodeCalculator
{
    public class ResistanceCalculator : IOhmValueCalculator
    {
        /// <summary>
        /// Calculates the Ohm value ( upper bound tolerance) of a resistor based on the band colors.
        /// </summary>
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal multiplier band.</param>
        /// <param name="bandDColor">The color of the tolerance value band.</param>
        /// <returns>A custom object containing range of actual value in ohms</returns>
        public ColorCodeResult CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            //Intialize color-code dictionary checkers 
            OhmCalculationInput ohmInput = new OhmCalculationInput();

            //get color codes from color-code dictionaries
            int ohmValue = Convert.ToInt32(string.Format("{0}{1}", ohmInput.significantFigures[bandAColor], ohmInput.significantFigures[bandBColor]));
            int multiplier = ohmInput.multiplier[bandCColor];
            double tolerance = ohmInput.tolerance[bandDColor];

            // find maximum and minimum resistance values
            double resultMax = (ohmValue * Math.Pow(10, multiplier) * (1 + tolerance));
            double resultMin = (ohmValue * Math.Pow(10, multiplier) * (1 - tolerance));

            // save the results in ColorCodeResult object
            ColorCodeResult ccResult = new ColorCodeResult();
            ccResult.MinimumResistance = FormatResistance(resultMin);
            ccResult.MaximumResistance = FormatResistance(resultMax);

            // return resistance value range.
            return ccResult;
        }


        /// <summary>
        /// Used to format large resistance values
        /// </summary>
        /// <param name="num"> resistance value </param>
        /// <returns>frmatted string of a resistance value</returns>
        public string FormatResistance(double num)
        {
            //to show in Mega format 
            if (num >= 100000000)
                return (num / 1000000).ToString("#,0M");
           
            else if (num >= 10000000)
                return (num / 1000000).ToString("0.#") + "M";
            //to show in Kilo format
            else if (num >= 100000)
                return (num / 1000).ToString("#,0K");

            else if (num >= 10000)
                return (num / 1000).ToString("0.#") + "K";

            else
                return num.ToString();

        }


        
    }

}
