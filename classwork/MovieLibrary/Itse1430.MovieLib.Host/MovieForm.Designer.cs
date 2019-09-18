namespace Itse1430.MovieLib.Host
{
    partial class MovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.cbRating = new System.Windows.Forms.ComboBox();
            this.txtRunLength = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkHaveSeen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Release Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rating:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Run Length:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(181, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(181, 150);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(100, 20);
            this.txtReleaseYear.TabIndex = 6;
            // 
            // cbRating
            // 
            this.cbRating.FormattingEnabled = true;
            this.cbRating.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R"});
            this.cbRating.Location = new System.Drawing.Point(181, 207);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(121, 21);
            this.cbRating.TabIndex = 7;
            // 
            // txtRunLength
            // 
            this.txtRunLength.Location = new System.Drawing.Point(181, 276);
            this.txtRunLength.Name = "txtRunLength";
            this.txtRunLength.Size = new System.Drawing.Size(100, 20);
            this.txtRunLength.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(395, 74);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(293, 173);
            this.txtDescription.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(469, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(565, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // chkHaveSeen
            // 
            this.chkHaveSeen.AutoSize = true;
            this.chkHaveSeen.Location = new System.Drawing.Point(181, 77);
            this.chkHaveSeen.Name = "chkHaveSeen";
            this.chkHaveSeen.Size = new System.Drawing.Size(86, 17);
            this.chkHaveSeen.TabIndex = 12;
            this.chkHaveSeen.Text = "Have Seen?";
            this.chkHaveSeen.UseVisualStyleBackColor = true;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 356);
            this.Controls.Add(this.chkHaveSeen);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtRunLength);
            this.Controls.Add(this.cbRating);
            this.Controls.Add(this.txtReleaseYear);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovieForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movie Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.ComboBox cbRating;
        private System.Windows.Forms.TextBox txtRunLength;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkHaveSeen;
    }
}