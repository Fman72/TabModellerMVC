using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TabModellerMVC
{
    /// <summary>
    /// This is the complex bar class. It contains attributes and behaviour unique to complex bars.
    /// </summary>
    [Serializable()]
    class ComplexBar : Bar
    {
        public static Regex COMPLEX_BAR_IDENTIFIER_REGEX = new Regex(@"(^[\|GABCDEFG]\S+\| *)", RegexOptions.IgnoreCase);

        /// <summary>
        /// This function attempts to create a complexBar object from an array of strings. If the strings are in the correct format it is successful.
        /// </summary>
        /// <param name="lines">An array of line to create the object out of.</param>
        /// <returns>A ComplexBar object if successful. Null if not.</returns>
        public static ComplexBar parse(string[] lines)
        {
            foreach (string line in lines)
            {
                if (!COMPLEX_BAR_IDENTIFIER_REGEX.IsMatch(line))
                {
                    return null;
                }
            }
            ComplexBar complexBar = new ComplexBar();
            complexBar.lines = lines;
            return complexBar;
        }
    }
}
