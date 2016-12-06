using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TabModellerMVC
{
    /// <summary>
    /// This is the simple bar class. It contains attributes and behaviours unique to simple bars.
    /// </summary>
    [Serializable()]
    class SimpleBar: Bar
    {
        //Regex used to identify tab in Strings. Matches strings that begin with |, G, D, A, or E and end with another |.
        public static Regex SIMPLE_BAR_IDENTIFIER_REGEX = new Regex(@"(^[\|GABCDEFG][\d\|\-]+\| *)", RegexOptions.IgnoreCase);

        /// <summary>
        /// This function attempts to create a simpleBar object from an array of strings. If the strings are in the correct format it is successful.
        /// </summary>
        /// <param name="lines">An array of line to create the object out of.</param>
        /// <returns>A SimpleBar object if successful. Null if not.</returns>
        public static SimpleBar parse(string[] lines)
        {
            foreach (string line in lines)
            {
                if (!SIMPLE_BAR_IDENTIFIER_REGEX.IsMatch(line))
                {
                    return null;
                }
            }
            SimpleBar simpleBar = new SimpleBar();
            simpleBar.lines = lines;
            return simpleBar;
        }
    }
}
