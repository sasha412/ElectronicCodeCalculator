# ElectronicCodeCalculator
The electronic color code (http://en.wikipedia.org/wiki/Electronic_color_code) is used to indicate the values or ratings of electronic components, very commonly for resistors. 

1. Wrote a class that implements the following interface. 
      public interface IOhmValueCalculator
      {
         /// <summary>
         /// Calculates the Ohm value of a resistor based on the band colors.
         /// </summary>
         /// <param name="bandAColor">The color of the first figure of component value band.</param>
         /// <param name="bandBColor">The color of the second significant figure band.</param>
         /// <param name="bandCColor">The color of the decimal multiplier band.</param>
         /// <param name="bandDColor">The color of the tolerance value band.</param>
         ColorCodeResult CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);

      }

2. Used visual studio unit test framework to write the unit tests I felt are necessary to adequately test the code I wrote.

3. Created a .NET MVC web interface that will allow someone to use the calculator I created in step one.

4. Developed a mobile first repsonsive view using JavaScript, CSS3, & HTML5.

