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
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();
        }
        #region Menu Items...
        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm();
            form.ShowDialog(this);
        }

        private void OnCharacterNew ( object sender, EventArgs e )
        {
            var form = new CharacterForm();
            
            if(form.ShowDialog(this) == DialogResult.OK)
            {
                AddCharacter(form.Character);
                UpdateUI();
            }
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            var form = new CharacterForm();
            form.Character = character;

            if (form.ShowDialog (this) == DialogResult.OK)
            {
                RemoveCharacter(character);
                AddCharacter(form.Character);
                UpdateUI();
            }
        }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            // Confirm delete
            var msg = $"Are you sure you want to delete {character.Name}?";
            var result = MessageBox.Show(msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            // Delete character
            RemoveCharacter(character);
            UpdateUI();
        }
        #endregion

        #region Helper Methods...
        // Used by OnCharacterEdit
        private Character GetSelectedCharacter()
        {
            var item = _lstCharacters.SelectedItem;

            return item as Character;
        }

        private void UpdateUI()
        {
            var characters = GetCharacters();

            _lstCharacters.DataSource = characters;
        }

        private void AddCharacter ( Character character )
        {
            // Add to _characters array
            for (var index = 0; index < _characters.Length; ++index)
            {
                if(_characters[index] == null)
                {
                    _characters[index] = character;
                    return;
                }
            }
        }

        private void RemoveCharacter (Character character)
        {
            // Remove from array
            for (var index = 0; index < _characters.Length; ++index)
            {
                if(_characters[index].Equals(character))
                {
                    _characters[index] = null;
                    return;
                };
            };
        }

        private Character[] GetCharacters ()
        {
            // Filter empty characters
            var count = 0;
            foreach (var character in _characters)
                if (character != null)
                    ++count;

            var index = 0;
            var characters = new Character[count];
            foreach (var character in _characters)
                if (character != null)
                    characters[index++] = character;

            return characters;
        }
        #endregion

        // Character array
        private Character[] _characters = new Character[100];
    }
}
