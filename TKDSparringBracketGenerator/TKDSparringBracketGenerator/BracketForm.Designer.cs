namespace TKDSparringBracketGenerator
{
    partial class BracketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BracketDisplay = new System.Windows.Forms.ListView();
            this.Division = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contestant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Belt_Rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight_Class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BracketDisplay
            // 
            this.BracketDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Division,
            this.Contestant,
            this.Belt_Rank,
            this.Weight_Class,
            this.Gender});
            this.BracketDisplay.Location = new System.Drawing.Point(12, 9);
            this.BracketDisplay.Name = "BracketDisplay";
            this.BracketDisplay.Size = new System.Drawing.Size(376, 269);
            this.BracketDisplay.TabIndex = 0;
            this.BracketDisplay.UseCompatibleStateImageBehavior = false;
            this.BracketDisplay.View = System.Windows.Forms.View.Details;
            this.BracketDisplay.SelectedIndexChanged += new System.EventHandler(this.BracketForm_Load);
            // 
            // Division
            // 
            this.Division.Text = "Division";
            // 
            // Contestant
            // 
            this.Contestant.Text = "Name";
            // 
            // Belt_Rank
            // 
            this.Belt_Rank.Text = "Belt Rank";
            // 
            // Weight_Class
            // 
            this.Weight_Class.Text = "Weight Class";
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            // 
            // BracketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 289);
            this.Controls.Add(this.BracketDisplay);
            this.Name = "BracketForm";
            this.Text = "BracketForm";
            this.Load += new System.EventHandler(this.BracketForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView BracketDisplay;
        private System.Windows.Forms.ColumnHeader Contestant;
        private System.Windows.Forms.ColumnHeader Belt_Rank;
        private System.Windows.Forms.ColumnHeader Weight_Class;
        private System.Windows.Forms.ColumnHeader Division;
        private System.Windows.Forms.ColumnHeader Gender;
    }
}