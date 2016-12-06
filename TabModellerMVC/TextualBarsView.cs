using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TabModellerMVC
{
    public partial class TextualBarsForm : Form, ITabModellerView
    {

        public static String REST_STRING = "Rest for one beat";

        //Model for this class.
        TabModellerModel tabModellerModel;

        /// <summary>
        /// The constructor for the textual bar view. Calls the TabModellerView super class constructor.
        /// </summary>
        /// <param name="tabModellerModel">The model for this view.</param>
        public TextualBarsForm(TabModellerModel tabModellerModel)
        {
            this.tabModellerModel = tabModellerModel;
            InitializeComponent();
        }

        /// <summary>
        /// This function updates the GraphicalBarView with new data from the model.
        /// </summary>
        /// <param name="bars">An array of Bar objects to update the view with.</param>
        public void update(List<Bar> bars)
        {
            List<String> textualBarRepresentation = new List<String>();
            //For each bar.
            for (int i = 0; i < bars.Count; i++)
            {
                //Finding length of longest line for each bar.
                textualBarRepresentation.Add("Bar " + (i + 1) + ":" + Environment.NewLine);
                Bar bar = bars[i];
                int longestLength = 0;
                foreach (String line in bar.lines)
                {
                    if (line.Length > longestLength)
                    {
                        longestLength = line.Length;
                    }
                }
                //For each character in a line of the bar.
                //Looking for the note in the 4 lines to determine if there is a note to play or if it is a rest.
                for (int x = 0; x < longestLength; x++)
                {
                    int currentLine = 0;
                    try {
                        if (!Regex.IsMatch(bar.lines[currentLine][x].ToString(), @"\||G|D|A|E|g|d|a|e"))
                        {
                            //For each line.
                            //Iterating through position stringPosition on all 4 strings.
                            while (currentLine < 4)
                            {
                                try {
                                    if (Regex.IsMatch(bar.lines[currentLine][x].ToString(), @"X"))
                                    {
                                        textualBarRepresentation.Add(this.parseSpecialNote(ref x, bar, currentLine));
                                        currentLine++;
                                    }
                                    else if (Regex.IsMatch(bar.lines[currentLine][x].ToString(), @"/|p|h|\\"))
                                    {
                                        textualBarRepresentation.Add(this.parseSymbol(ref x, bar, currentLine));
                                        currentLine++;
                                    }
                                    else if (Regex.IsMatch(bar.lines[currentLine][x].ToString(), @"\d"))
                                    {
                                        textualBarRepresentation.Add(this.parseNote(ref x, bar, currentLine));
                                        currentLine++;
                                    }
                                    else
                                    {
                                        if (currentLine == 3)
                                        {
                                            textualBarRepresentation.Add(REST_STRING);
                                        }
                                        currentLine++;
                                    }
                                }
                                catch (IndexOutOfRangeException ex)
                                {
                                    currentLine = 4;
                                }
                            }
                        }
                    }
                    //If index out of range this early means there is a bar with tag.
                    catch(IndexOutOfRangeException ex)
                    {

                    }
                }
                //Adding a new line at the end of every bar for formatting.
                textualBarRepresentation.Add(Environment.NewLine);
            }
            //Adding textual representation to the text box.
            this.barsTextBox.Lines = textualBarRepresentation.ToArray();
        }
        /// <summary>
        /// Finds a note in the tab and increments stringPosition to the next character if it is a double digit note.
        /// </summary>
        /// <param name="x">The position in the String that is being parsed. Is incremented by this function if a double digit number is parsed.</param>
        /// <param name="bar">The bar currently being parsed.</param>
        /// <param name="currentLine">The currentLine being parsed.</param>
        /// <returns></returns>
        public String parseNote(ref int stringPosition, Bar bar, int currentLine)
        {
            int note = -1;
            if (bar.lines[currentLine][stringPosition].ToString().Equals("|"))
            {
                stringPosition++;
            }
            //Handle double digit numbers.
            if (Regex.IsMatch(bar.lines[currentLine][stringPosition + 1].ToString(), @"\d"))
            {
                if (Int32.Parse((bar.lines[currentLine][stringPosition].ToString()) + (bar.lines[currentLine][stringPosition + 1].ToString())) < 25)
                {
                    //Note is concatentation of two numbers.
                    note = Int32.Parse((bar.lines[currentLine][stringPosition].ToString()) + (bar.lines[currentLine][stringPosition + 1].ToString()));
                    //Skip next number.
                    stringPosition++;
                }
                //If two single numbers next to each other treat as singles.
                else
                {
                    note = Int32.Parse(bar.lines[currentLine][stringPosition].ToString());
                }
            }
            //If not double digit make note the current digit.
            else
            {
                note = Int32.Parse(bar.lines[currentLine][stringPosition].ToString());
            }
            return "Play a " + Bar.convertNumberToNote(note, currentLine);
        }

        public String parseSymbol(ref int stringPosition, Bar bar, int currentLine)
        {
            Char symbol = bar.lines[currentLine][stringPosition];
            //Find the next number for the symbol to interact with.
            stringPosition++;
            String note = this.parseNote(ref stringPosition, bar, currentLine);
            if (symbol.Equals('/'))
            {
                return "Slide up to play " + note;
            }
            else if (symbol.Equals('\\'))
            {
                return "Slide down to play " + note;
            }
            else if (symbol.Equals('h'))
            {
                return "Hammer on to play " + note;
            }
            else
            {
                return "Pull off to play " + note;
            }
        }

        public String parseSpecialNote(ref int stringPosition, Bar bar, int currentLine)
        {
            stringPosition++;
            return "Play a muted note on the " + Bar.convertNumberToNote(0, currentLine) + " string.";
        }



        //EVENT HANDLERS

        /// <summary>
        /// This function runs when this form is closed. It exits the application.
        /// </summary>
        /// <param name="sender">The sender of this event. In this case the form.</param>
        /// <param name="e">The event args for the event.</param>
        private void TextualBarsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
