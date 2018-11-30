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
            this.SuspendLayout();
            // 
            // BracketDisplay
            // 
            this.BracketDisplay.Location = new System.Drawing.Point(12, 9);
            this.BracketDisplay.Name = "BracketDisplay";
            this.BracketDisplay.Size = new System.Drawing.Size(357, 269);
            this.BracketDisplay.TabIndex = 0;
            this.BracketDisplay.UseCompatibleStateImageBehavior = false;
            this.BracketDisplay.SelectedIndexChanged += new System.EventHandler(this.BracketForm_Load);
            // 
            // BracketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 290);
            this.Controls.Add(this.BracketDisplay);
            this.Name = "BracketForm";
            this.Text = "BracketForm";
            this.Load += new System.EventHandler(this.BracketForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView BracketDisplay;
    }
}