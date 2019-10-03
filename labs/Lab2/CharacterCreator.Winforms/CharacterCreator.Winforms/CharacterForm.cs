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

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            if (Character != null)
            {
                _txtCharacterName.Text = Character.Name;
                cbProfession.Text = Character.Profession;
                cbRace.Text = Character.Race;
                _txtStamina.Text = Character.Stamina.ToString();
                _txtAgility.Text = Character.Agility.ToString();
                _txtIntellect.Text = Character.Intellect.ToString();
                _txtSpirit.Text = Character.Spirit.ToString();
                _txtStrength.Text = Character.Strength.ToString();
            }
            else
            {
                var character = new Character();
                _txtStamina.Text = character.Stamina.ToString();
                _txtAgility.Text = character.Agility.ToString();
                _txtIntellect.Text = character.Intellect.ToString();
                _txtSpirit.Text = character.Spirit.ToString();
                _txtStrength.Text = character.Strength.ToString();
            }
        }

        public Character Character { get; set; }

        private void OnSave ( object sender, EventArgs e )
        {
            // Save new character
            var character = new Character();

            character.Name = _txtCharacterName.Text;
            character.Race = cbRace.Text;
            character.Profession = cbProfession.Text;
            character.Stamina = GetAsInt32(_txtStamina);
            character.Agility = GetAsInt32(_txtAgility);
            character.Intellect = GetAsInt32(_txtIntellect);
            character.Spirit = GetAsInt32(_txtSpirit);
            character.Strength = GetAsInt32(_txtStrength);

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

        private void OnCancel ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
