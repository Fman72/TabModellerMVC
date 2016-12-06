using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabModellerMVC
{


    public class TabModellerController
    {
        //Collection of views.
        public List<ITabModellerView> tabModellerViews = new List<ITabModellerView>();

        /// <summary>
        /// This is the constructor for the tabModellerController it initializes the views in the application.
        /// </summary>
        public TabModellerController()
        {
            TabModellerModel tabModellerModel = new TabModellerModel(this);
            this.addView(new GraphicalBarsForm(tabModellerModel));
            this.addView(new TextualBarsForm(tabModellerModel));
            this.addView(new FilteredBarsView(tabModellerModel));
        }


        /// <summary>
        /// This function adds a view to the list of tabModellerViews the controller has.
        /// </summary>
        /// <param name="tabModellerView">The tabModellerView to add.</param>
        public void addView(ITabModellerView tabModellerView)
        {
            this.tabModellerViews.Add(tabModellerView);
        }

        /// <summary>
        /// This function updates all the views the controller has in it's collection of views.
        /// </summary>
        public void updateViews(List<Bar> bars)
        {
            foreach (ITabModellerView tabModellerView in tabModellerViews)
            {
                tabModellerView.update(bars);
            }
        }

        /// <summary>
        /// This function shows all the views the controller has in it's collection of views.
        /// </summary>
        public void showViews()
        {
            foreach (Form tabModellerView in tabModellerViews)
            {
                tabModellerView.Show();
            }
        }

    }
}
