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
    public partial class EntryForm : Form
    {
        public List<Competitor> enteredCompetitors { get; }
        public EntryForm()
        {
            InitializeComponent();
            enteredCompetitors = new List<Competitor>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newPersonForm = new Form1();
            newPersonForm.ShowDialog(this);
        }

        public void AddCompetitor(Competitor competitor)
        {
            string[] items = new string[] {
                competitor.Name,
                competitor.Gender.ToString(),
                competitor.Rank.ToString(),
                competitor.WeightClass.ToString(),
                competitor.Division//TODO change to Divison when can
            };
            Console.WriteLine(items[1]);
            ListViewItem item = new ListViewItem(items);
            competitorListView.Items.Add(item);
            enteredCompetitors.Add(competitor);//added the competitor to the list for the algorithm
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BracketForm newBracketForm = new BracketForm();
            newBracketForm.ShowDialog(this);

        }

      /*  public void AddBracket(List<Competitor> comps)
        {
            ListViewItem item = new ListViewItem(comps);

        }

        */
    }
}
