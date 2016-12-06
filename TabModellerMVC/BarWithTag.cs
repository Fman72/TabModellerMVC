using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TabModellerMVC
{
    /// <summary>
    /// This is the bar with tag class. It contians attributes and behaviours unique to bars with tags.
    /// </summary>
    [Serializable()]
    class BarWithTag : Bar
    {
        //Regex used to identify tab with brackets after the tab.
        public static Regex BAR_WITH_TAG_IDENTIFIER_REGEX = new Regex(@"(^[\|GABCDEFG]\S+\| +\S+$)", RegexOptions.IgnoreCase);

        public String tag { get; set; }

        /// <summary>
        /// This function attempts to create a barWithTag object from an array of strings. If the strings are in the correct format it is successful.
        /// </summary>
        /// <param name="lines">An array of line to create the object out of.</param>
        /// <returns>A BarWithTag object if successful. Null if not.</returns>
        public static BarWithTag parse(string[] lines)
        {
            foreach(string line in lines)
            {
                if (BAR_WITH_TAG_IDENTIFIER_REGEX.IsMatch(line))
                {
                    BarWithTag barWithTag = new BarWithTag();
                    barWithTag.lines = lines;
                    return barWithTag;
                }
            }
            return null;
        }
    }
}
