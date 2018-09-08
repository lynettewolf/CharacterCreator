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
        private LanguageInterface li = new LanguageInterface();
        private WeaponsInterface wi = new WeaponsInterface();
        private FeatsInterface fi = new FeatsInterface();
        private SpecialAbilitiesInterface SpAbInt = new SpecialAbilitiesInterface();
        private InventoryInterface ii = new InventoryInterface();
        private SkillsInterface ski = new SkillsInterface();
        private SpellsInterface spi = new SpellsInterface();

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
            li.InitializeCheckBoxes(languages);
            if(li.ShowDialog() == DialogResult.OK)
            {
                uxLanguageList.Clear();
                uxLanguageList.Lines = li.GetLanguages();
            }
        }

        private void uxWeaponsButton_Click(object sender, EventArgs e)
        {
            
            wi.Show();
        }

        private void uxFeatsButton_Click(object sender, EventArgs e)
        {
            
            fi.Show();
        }

        private void uxSpecialAbilitiesButton_Click(object sender, EventArgs e)
        {
            
            SpAbInt.Show();
        }

        private void uxInventoryButton_Click(object sender, EventArgs e)
        {
            
            ii.Show();
        }

        private void uxSkillsButton_Click(object sender, EventArgs e)
        {
            
            ski.Show();
        }

        private void uxSpellsButton_Click(object sender, EventArgs e)
        {
            spi.Show();
        }
    }
}
