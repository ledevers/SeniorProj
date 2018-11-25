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
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string name = Name_TextBox.Text;
            string rank = Belt_Rank_ListBox.Text;
            string gender = GenderBox.Text;       
            int height = Convert.ToInt32(Height_TextBox.Text);
            double weight = Convert.ToDouble(Weight_TextBox.Text);   

            Competitor person = new Competitor(name, rank, gender, height, weight);
            Console.WriteLine(gender);
            // WARNING! Will cause error if form's owner is not EntryForm
            EntryForm entryForm = (EntryForm) this.Owner;
            entryForm.AddCompetitor(person);
            this.Close();
        }

      /*  public Gender checkGender()
        {
            if(GenderBox.Text == "Female")
            {
                return Gender.FEMALE;
            }
            else
            {
                return Gender.MALE;
            }
                 
            if(((string) GenderBox.SelectedItems[0]) == "Female")
            {
                return Gender.FEMALE; 
            }
            else
            {
                return Gender.MALE;
            }
            
            Console.WriteLine(GenderBox.SelectedItem);
           // return (Gender)GenderBox.SelectedItem;
        }
      */

        //weight classes can be combined to the weight class above if only 1 person is in the weight class, need a min of 2 to fight


    }
}
