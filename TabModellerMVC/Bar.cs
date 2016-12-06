using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TabModellerMVC
{
    //An enum holding all the possible types of bars.
    public enum TypeOfBar { NotBar = 0, SimpleBar, ComplexBar, BarWithTag };
    [Serializable()]
    public class Bar
    {
        //String that model the notes on the strings. Used to convert the numbers on the graphical representations to the required notes.
        public static String[] G_STRING_NOTES = { "G", "G#", "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G" };
        public static String[] D_STRING_NOTES = { "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C", "C#", "D" };
        public static String[] A_STRING_NOTES = { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A" };
        public static String[] E_STRING_NOTES = { "E", "F", "F#", "G", "G#", "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C", "C#", "D", "D#", "E" };

        public static String[][] FRETBOARD = { G_STRING_NOTES, D_STRING_NOTES, A_STRING_NOTES, E_STRING_NOTES };

        public String[] lines = new String[4];

        /// <summary>
        /// This function returns the note on the fretboard corresponding to the number in a tab.
        /// </summary>
        /// <param name="fret">An int indicating the fret on the fretboard.</param>
        /// <param name="guitarString">An int indicating the string that the fret is on.</param>
        /// <returns></returns>
        public static String convertNumberToNote(int fret, int guitarString)
        {
            return FRETBOARD[guitarString][fret];
        }
    }
}
