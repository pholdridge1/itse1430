using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CharacterForm : Form
    {
        public CharacterForm ()
        {
            InitializeComponent();
        }

        public Character Character { get; set; }

        private void OnSave ( object sender, EventArgs e )
        {
            // Save new character
            var character = new Character();

            character.Name = txtCharacterName.Text;
            character.Race = cbRace.Text;
            character.Profession = cbProfession.Text;
            character.Stamina = GetAsInt32(txtStamina);
            character.Agility = GetAsInt32(txtAgility);
            character.Intellect = GetAsInt32(txtIntellect);
            character.Spirit = GetAsInt32(txtSpirit);
            character.Strength = GetAsInt32(txtStrength);

            // Validate
            var message = character.Validate();
            if(!String.IsNullOrEmpty(message))
            {
                MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Character = character;

            DialogResult = DialogResult.OK;
            Close();
        }

        private int GetAsInt32 ( TextBox control )
        {
            if (Int32.TryParse(control.Text, out var result))
                return result;

            return 0;
        }
    }
}
