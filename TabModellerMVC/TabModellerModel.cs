using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TabModellerMVC
{
    public class TabModellerModel
    {

        //The Controller for this model.
        private TabModellerController tabModellerController;

        //Property used to store the user's tab. (A collection of data objects.)
        public List<Bar> bars { get; set; }

        //PROPERTIES

        //Property used to store the current pull off symbol defaults to 'p'.
        public char currentPullOffSymbol { get; set; } = 'p';

        //Property used to store the current pull off symbol defaults to 'h'
        public char currentHammerOnSymbol { get; set; } = 'h';

        //Property used to store the current pull off symbol defaults to '|'
        public char currentBendSymbol { get; set; } = '~';

        //property used to identify the number of strings in the bass tab. Defaults to 4.
        public int numberOfStrings { get; set; } = 4;

        //Property used to tell a save file whether or not numbers are highlighted in the tab.
        public Boolean numbersHighlighted { get; set; } = false;

        //Property used to tell a save file whether or not other symbols are hightlighted in the tab.
        public Boolean otherSymbolsHighlighted { get; set; } = false;

        private BinaryFormatter binaryFormatter;

        ///<summary>
        /// This is the constructor for the TabModellerModel. It initializes key variables of the class.
        /// <param name="tabModellerController">A reference to the controller for this TabModellerModel class.</param>
        /// </summary>
        public TabModellerModel(TabModellerController tabModellerController)
        {
            this.tabModellerController = tabModellerController;
            bars = new List<Bar>();
            binaryFormatter = new BinaryFormatter();
        }

        /// <summary>
        /// This function updates all the views in the application.
        /// </summary>
        public void updateViews()
        {
            this.tabModellerController.updateViews(bars);
        }

        //Serialization Functions

        /// <summary>
        /// This function serializes all the bars in the model to the specified file.
        /// </summary>
        /// <param name="fileName">The file to serialize the bars to.</param>
        public void serializeAllBars(String fileName)
        {
            FileInfo fileToSerializeTo = new FileInfo(fileName);
            //Opening writable stream to the file object.
            Stream stream = fileToSerializeTo.Open(FileMode.Create, FileAccess.ReadWrite);
            //Serializing all the bars to the file.
            foreach (Bar bar in bars)
            {
                this.binaryFormatter.Serialize(stream, bar);
            }
            //Closing the stream.
            stream.Close();
        }

        /// <summary>
        /// This function deserializes all the bar objects from a file on the file system.
        /// </summary>
        /// <param name="fileName">The file to deserialize the objects from.</param>
        public void deserializeAllBars(String fileName)
        {
            this.bars.Clear();
            FileInfo fileToDeserializeFrom = new FileInfo(fileName);
            //Creating stream from file with bars.
            Stream stream = fileToDeserializeFrom.Open(FileMode.Open);
            //Adding all the bars from the file to the bars list.
            while (stream.Position != stream.Length)
            {
                this.bars.Add((Bar)this.binaryFormatter.Deserialize(stream));
            }
            stream.Close();
        }

        //Data Handling Functions
        /// <summary>
        /// This function adds an array of bars to the model and updates the views.
        /// </summary>
        /// <param name="linesToAdd">The lines of the Bars to add.</param>
        public void addBars(List<string[]> linesToAdd)
        {
            List<Bar> barsToAdd = new List<Bar>();
            foreach(string[] lines in linesToAdd)
            {
                barsToAdd.Add(this.createBar(lines));
            }
            bars.AddRange(barsToAdd);
            this.updateViews();
        }

        /// <summary>
        /// This function creates a bar object using the liens that is passed to it.
        /// </summary>
        /// <param name="lines">The lines of the Bar to add.</param>
        public Bar createBar(string[] lines)
        {
            if(BarWithTag.parse(lines) != null)
            {
                return BarWithTag.parse(lines);
            }
            else if (SimpleBar.parse(lines) != null)
            {
                return SimpleBar.parse(lines);
            }
            else 
            {
                return ComplexBar.parse(lines);
            }
        }

        /// <summary>
        /// This function validates a line to check that it is a type of tab. It is used by the views before they submit data to the model.
        /// </summary>
        /// <param name="line">The line to check.</param>
        /// <returns>A boolean indicating whether or not the line is tab.</returns>
        public static Boolean validateLine(string line)
        {
            if (SimpleBar.SIMPLE_BAR_IDENTIFIER_REGEX.IsMatch(line) || ComplexBar.COMPLEX_BAR_IDENTIFIER_REGEX.IsMatch(line) || BarWithTag.BAR_WITH_TAG_IDENTIFIER_REGEX.IsMatch(line))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// This function modifies an existing bar in the bars and updates the views.
        /// </summary>
        /// <param name="lines">The new lines to update the bar with.</param>
        /// <param name="indexToModify">The index of the bar to update.</param>
        public void modifyBar(String[] lines, int indexToModify)
        {
            Bar barToAdd = this.createBar(lines);
            bars[indexToModify] = barToAdd;
            this.updateViews();
        }

        /// <summary>
        /// This function deletes one of the bars in the users tab.
        /// </summary>
        /// <param name="indexToDelete">The index of the bar to delete.</param>
        public void deleteBar(int indexToDelete)
        {
            //If there is no data don't delete anything.
            if(bars.Count == 0)
            {
                return;
            }
            bars.RemoveAt(indexToDelete);
            this.updateViews();
        }

        /// <summary>
        /// This function deletes all the bars in the model.
        /// </summary>
        public void deleteAllBars()
        {
            bars.Clear();
            this.tabModellerController.updateViews(bars);
        }
    }
}
