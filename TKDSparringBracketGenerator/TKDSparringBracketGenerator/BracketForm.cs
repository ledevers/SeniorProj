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
            bracketAlgorithm = new BracketAlgorithm(entryForm.enteredCompetitors);
        }
    }
}
