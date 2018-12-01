using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKDSparringBracketGenerator
{
    public partial class BracketForm : Form
    {
        private BracketAlgorithm bracketAlgorithm;



        public BracketForm()
        {
            InitializeComponent();
        }

        private void BracketForm_Load(object sender, EventArgs e)
        {
            // WARNING! Will cause error if form's owner is not EntryForm
            EntryForm entryForm = (EntryForm)this.Owner;
            //Loads the competitors into the general listView
            List<Competitor> list = entryForm.enteredCompetitors;
            bracketAlgorithm = new BracketAlgorithm(list);
            // ListViewItem asListViewItems = new ListViewItem();

            for (int i = 0; i < list.Count; i++)
            {
                string[] items = new string[] {
                bracketAlgorithm.Competitors[i].Name,
                bracketAlgorithm.Competitors[i].Gender.ToString(),
                bracketAlgorithm.Competitors[i].Rank.ToString(),
                bracketAlgorithm.Competitors[i].WeightClass.ToString(),
                bracketAlgorithm.Competitors[i].Division
                };

                //asListViewItems.SubItems.AddRange

                //adding bracket to the display
                ListViewItem nextItem = new ListViewItem(items);
                BracketDisplay.Items.Add(nextItem);

            }
            //Loads the Competitors into the treeView

        }
           
    }
}
