using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCodeCalculator
{
    /// <summary>
    /// Stores range of Resistance 
    /// </summary>
    public class ColorCodeResult
    {
        //Minimum resistance value after tolerance is applied
       public string MinimumResistance { get; set; }
        //Maximum resistance value after tolerance is applied
        public string MaximumResistance { get; set; }
    }
}
