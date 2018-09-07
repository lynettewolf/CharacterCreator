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
        public MainInterface()
        {
            InitializeComponent();
        }

        private void uxEditLanguages_Click(object sender, EventArgs e)
        {
            LanguageInterface li = new LanguageInterface();
            li.Show();
        }
    }
}
