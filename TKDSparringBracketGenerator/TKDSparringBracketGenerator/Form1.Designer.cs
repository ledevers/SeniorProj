namespace TKDSparringBracketGenerator
{
    partial class Form1
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
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Height_TextBox = new System.Windows.Forms.TextBox();
            this.Weight_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Belt_Rank_ListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.GenderBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(183, 12);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(166, 20);
            this.Name_TextBox.TabIndex = 0;
            // 
            // Height_TextBox
            // 
            this.Height_TextBox.Location = new System.Drawing.Point(183, 172);
            this.Height_TextBox.Name = "Height_TextBox";
            this.Height_TextBox.Size = new System.Drawing.Size(166, 20);
            this.Height_TextBox.TabIndex = 1;
            // 
            // Weight_TextBox
            // 
            this.Weight_TextBox.Location = new System.Drawing.Point(183, 131);
            this.Weight_TextBox.Name = "Weight_TextBox";
            this.Weight_TextBox.Size = new System.Drawing.Size(166, 20);
            this.Weight_TextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Competitor\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Belt Ranking";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender";
            // 
            // Belt_Rank_ListBox
            // 
            this.Belt_Rank_ListBox.FormattingEnabled = true;
            this.Belt_Rank_ListBox.Location = new System.Drawing.Point(183, 38);
            this.Belt_Rank_ListBox.Name = "Belt_Rank_ListBox";
            this.Belt_Rank_ListBox.Size = new System.Drawing.Size(166, 43);
            this.Belt_Rank_ListBox.TabIndex = 8;
    
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Weight (in kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Height (in Inches)";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(202, 208);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(125, 31);
            this.Submit.TabIndex = 11;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Location = new System.Drawing.Point(185, 91);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(163, 30);
            this.GenderBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 251);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Belt_Rank_ListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Weight_TextBox);
            this.Controls.Add(this.Height_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.Name = "Form1";
            this.Text = "TKD Bracket Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.TextBox Height_TextBox;
        private System.Windows.Forms.TextBox Weight_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Belt_Rank_ListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ListBox GenderBox;
    }
}

