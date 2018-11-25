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
        public EntryForm()
        {
            InitializeComponent();
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
                competitor.Gender,
                competitor.Rank,
                competitor.WeightClass.ToString(),
                competitor.Weight.ToString()//TODO change to Divison when can
            };
            Console.WriteLine(items[1]);
            ListViewItem item = new ListViewItem(items);
            competitorListView.Items.Add(item);
        }
    }
}
