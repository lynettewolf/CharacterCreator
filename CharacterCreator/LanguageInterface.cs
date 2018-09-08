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
    public partial class LanguageInterface : Form
    {

        public LanguageInterface()
        {
            InitializeComponent();
        }

        public void InitializeCheckBoxes(string[] languages)
        {
            foreach(string lang in languages)
            {
                int index = uxLanguageList.Items.IndexOf(lang);
                if (index >= 0)
                {
                    uxLanguageList.SetItemChecked(index, true);
                }
                
            }
        }

        public string[] GetLanguages()
        {
            var checkedItems = uxLanguageList.CheckedItems;
            string[] langArray = new string[checkedItems.Count];
            checkedItems.CopyTo(langArray, 0);
            return langArray;

        }
    }
}
