using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class MainInterface : Form
    {
        private LanguageForm _langForm = new LanguageForm();
        private WeaponsForm _weaponsForm = new WeaponsForm();
        private FeatsForm _featsForm = new FeatsForm();
        private SpecAbilitiesForm _specAbilitiesForm = new SpecAbilitiesForm();
        private InventoryForm _inventoryForm = new InventoryForm();
        private SkillsForm _skillsForm = new SkillsForm();
        private SpellsForm _spellsForm = new SpellsForm();
        private DescriptionForm _descriptionForm = new DescriptionForm();

        public MainInterface()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles Language click event. Allows for adding/removing of languages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEditLanguages_Click(object sender, EventArgs e)
        {
            char[] delimeters = { '\n', '\r' };
            string[] languages = uxLanguageList.Text.Split(delimeters);
            _langForm.InitializeCheckBoxes(languages);
            if(_langForm.ShowDialog() == DialogResult.OK)
            {
                uxLanguageList.Clear();
                uxLanguageList.Lines = _langForm.GetLanguages();
            }
        }

        private void uxWeaponsButton_Click(object sender, EventArgs e)
        {
            
            _weaponsForm.Show();
        }

        private void uxFeatsButton_Click(object sender, EventArgs e)
        {
            
            _featsForm.Show();
        }

        private void uxSpecialAbilitiesButton_Click(object sender, EventArgs e)
        {
            
            _specAbilitiesForm.Show();
        }

        private void uxInventoryButton_Click(object sender, EventArgs e)
        {
            
            _inventoryForm.Show();
        }

        private void uxSkillsButton_Click(object sender, EventArgs e)
        {
            
            _skillsForm.Show();
        }

        private void uxSpellsButton_Click(object sender, EventArgs e)
        {
            _spellsForm.Show();
        }

        private void uxCharacterDescriptionButton_Click(object sender, EventArgs e)
        {
            _descriptionForm.Show();
        }
    }
}
