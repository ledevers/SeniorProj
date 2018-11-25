namespace TKDSparringBracketGenerator
{
    partial class EntryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.competitorListView = new System.Windows.Forms.ListView();
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rankCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weightClassCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.divisonCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genderCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Competitors";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enroll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // competitorListView
            // 
            this.competitorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCol,
            this.genderCol,
            this.rankCol,
            this.weightClassCol,
            this.divisonCol});
            this.competitorListView.Location = new System.Drawing.Point(12, 25);
            this.competitorListView.Name = "competitorListView";
            this.competitorListView.Size = new System.Drawing.Size(426, 267);
            this.competitorListView.TabIndex = 3;
            this.competitorListView.UseCompatibleStateImageBehavior = false;
            this.competitorListView.View = System.Windows.Forms.View.Details;
            // 
            // nameCol
            // 
            this.nameCol.Text = "Name";
            // 
            // rankCol
            // 
            this.rankCol.DisplayIndex = 1;
            this.rankCol.Text = "Belt Rank";
            // 
            // weightClassCol
            // 
            this.weightClassCol.DisplayIndex = 2;
            this.weightClassCol.Text = "Weight Class";
            this.weightClassCol.Width = 90;
            // 
            // divisonCol
            // 
            this.divisonCol.DisplayIndex = 3;
            this.divisonCol.Text = "Divison";
            // 
            // genderCol
            // 
            this.genderCol.DisplayIndex = 4;
            this.genderCol.Text = "Gender";
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.competitorListView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "EntryForm";
            this.Text = "EntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView competitorListView;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader rankCol;
        private System.Windows.Forms.ColumnHeader weightClassCol;
        private System.Windows.Forms.ColumnHeader divisonCol;
        private System.Windows.Forms.ColumnHeader genderCol;
    }
}