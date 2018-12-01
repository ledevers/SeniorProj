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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenderBox.Items.Add(Gender.Male);
            GenderBox.Items.Add(Gender.Female);
            Belt_Rank_ListBox.Items.Add(BeltRank.White);
            Belt_Rank_ListBox.Items.Add(BeltRank.Yellow);
            Belt_Rank_ListBox.Items.Add(BeltRank.Orange);
            Belt_Rank_ListBox.Items.Add(BeltRank.Green);
            Belt_Rank_ListBox.Items.Add(BeltRank.Purple);
            Belt_Rank_ListBox.Items.Add(BeltRank.Blue);
            Belt_Rank_ListBox.Items.Add(BeltRank.Red_High_Red);
            Belt_Rank_ListBox.Items.Add(BeltRank.Recommended_Black);
            Belt_Rank_ListBox.Items.Add(BeltRank.First_Dan);
            Belt_Rank_ListBox.Items.Add(BeltRank.Second_Dan);
            Belt_Rank_ListBox.Items.Add(BeltRank.Third_Dan);
            Belt_Rank_ListBox.Items.Add(BeltRank.Fourth_Dan);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string name = Name_TextBox.Text;
            BeltRank rank = (BeltRank)Belt_Rank_ListBox.SelectedItem;
            Gender gender = (Gender)GenderBox.SelectedItem;       
            int height = Convert.ToInt32(Height_TextBox.Text);
            double weight = Convert.ToDouble(Weight_TextBox.Text);   

            Competitor person = new Competitor(name, rank, gender, height, weight);
            Console.WriteLine(gender);
            // WARNING! Will cause error if form's owner is not EntryForm
            EntryForm entryForm = (EntryForm) this.Owner;
            entryForm.AddCompetitor(person);
            this.Close();
        }
    }
}
