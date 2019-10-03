using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        #region Properties
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }

        public string Profession
        {
            get { return _profession ?? ""; }
            set { _profession = value; }
        }

        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value; }
        }

        public int Stamina { get; set; } = 50;
        public int Agility { get; set; } = 50;
        public int Intellect { get; set; } = 50;
        public int Spirit { get; set; } = 50;
        public int Strength { get; set; } = 50;

        #endregion

        public string Validate()
        {
            // Name is required.
            if (String.IsNullOrEmpty(this.Name))
                return "Name is required.";

            // Race is required
            if (String.IsNullOrEmpty(Race))
                return "Race is required.";

            // Profession is required.
            if (String.IsNullOrEmpty(Profession))
                return "Profession is required.";

            // Attributes must be > 0 or <= 100
            if (Stamina < 0 || Stamina >= 100)
                return "Stamina must be between 1 and 100.";
            else if (Agility <= 0 || Agility > 100)
                return "Agility must be between 1 and 100.";
            else if (Intellect <= 0 || Intellect > 100)
                return "Intellect must be between 1 and 100.";
            else if (Spirit <= 0 || Spirit > 100)
                return "Spirit must be between 1 and 100.";
            else if (Strength <= 0 || Strength > 100)
                return "Strength must be between 1 and 100.";

            return "";
        }

        #region Private Fields

        private string _name = "";
        private string _profession = "";
        private string _race = "";
        private string _description = "";
        #endregion
    }
}