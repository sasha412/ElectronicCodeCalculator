using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCodeCalculator
{
   public interface IOhmValueCalculator
    {
        /// <summary>
        /// Interface to Calculate the Ohm value of a resistor based on the band colors.
        /// </summary>
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal multiplier band.</param>
        /// <param name="bandDColor">The color of the tolerance value band.</param>
        /// <returns>A custom object containing range in actual value in ohms</returns>
       ColorCodeResult CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);
    }

   
}
