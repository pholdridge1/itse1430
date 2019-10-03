namespace CharacterCreator.Winforms
{
    partial class CharacterForm
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
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.label1 = new System.Windows.Forms.Label();
            this._txtCharacterName = new System.Windows.Forms.TextBox();
            this.cbRace = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbProfession = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._txtStrength = new System.Windows.Forms.TextBox();
            this._txtIntellect = new System.Windows.Forms.TextBox();
            this._txtStamina = new System.Windows.Forms.TextBox();
            this._txtSpirit = new System.Windows.Forms.TextBox();
            this._txtAgility = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Character Name:";
            // 
            // _txtCharacterName
            // 
            this._txtCharacterName.Location = new System.Drawing.Point(105, 201);
            this._txtCharacterName.Name = "_txtCharacterName";
            this._txtCharacterName.Size = new System.Drawing.Size(176, 20);
            this._txtCharacterName.TabIndex = 1;
            // 
            // cbRace
            // 
            this.cbRace.FormattingEnabled = true;
            this.cbRace.Items.AddRange(new object[] {
            "Dwarf",
            "Gnome",
            "Human",
            "Night Elf",
            "Orc",
            "Tauren",
            "Troll",
            "Undead"});
            this.cbRace.Location = new System.Drawing.Point(105, 12);
            this.cbRace.Name = "cbRace";
            this.cbRace.Size = new System.Drawing.Size(121, 21);
            this.cbRace.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Strength:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Intellect:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stamina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Spirit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Agility:";
            // 
            // cbProfession
            // 
            this.cbProfession.FormattingEnabled = true;
            this.cbProfession.Items.AddRange(new object[] {
            "Druid",
            "Hunter",
            "Mage",
            "Paladin",
            "Priest",
            "Rogue",
            "Shaman",
            "Warlock",
            "Warrior"});
            this.cbProfession.Location = new System.Drawing.Point(105, 39);
            this.cbProfession.Name = "cbProfession";
            this.cbProfession.Size = new System.Drawing.Size(121, 21);
            this.cbProfession.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Race:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Profession:";
            // 
            // _txtStrength
            // 
            this._txtStrength.Location = new System.Drawing.Point(105, 67);
            this._txtStrength.Name = "_txtStrength";
            this._txtStrength.Size = new System.Drawing.Size(37, 20);
            this._txtStrength.TabIndex = 11;
            // 
            // _txtIntellect
            // 
            this._txtIntellect.Location = new System.Drawing.Point(105, 94);
            this._txtIntellect.Name = "_txtIntellect";
            this._txtIntellect.Size = new System.Drawing.Size(37, 20);
            this._txtIntellect.TabIndex = 12;
            // 
            // _txtStamina
            // 
            this._txtStamina.Location = new System.Drawing.Point(105, 121);
            this._txtStamina.Name = "_txtStamina";
            this._txtStamina.Size = new System.Drawing.Size(37, 20);
            this._txtStamina.TabIndex = 13;
            // 
            // _txtSpirit
            // 
            this._txtSpirit.Location = new System.Drawing.Point(105, 148);
            this._txtSpirit.Name = "_txtSpirit";
            this._txtSpirit.Size = new System.Drawing.Size(37, 20);
            this._txtSpirit.TabIndex = 14;
            // 
            // _txtAgility
            // 
            this._txtAgility.Location = new System.Drawing.Point(105, 175);
            this._txtAgility.Name = "_txtAgility";
            this._txtAgility.Size = new System.Drawing.Size(37, 20);
            this._txtAgility.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(206, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 275);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this._txtAgility);
            this.Controls.Add(this._txtSpirit);
            this.Controls.Add(this._txtStamina);
            this.Controls.Add(this._txtIntellect);
            this.Controls.Add(this._txtStrength);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbProfession);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRace);
            this.Controls.Add(this._txtCharacterName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CharacterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtCharacterName;
        private System.Windows.Forms.ComboBox cbRace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbProfession;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _txtStrength;
        private System.Windows.Forms.TextBox _txtIntellect;
        private System.Windows.Forms.TextBox _txtStamina;
        private System.Windows.Forms.TextBox _txtSpirit;
        private System.Windows.Forms.TextBox _txtAgility;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}