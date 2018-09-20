using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Helper_Files
{
    public partial class RemoveDialog : Form
    {
        public RemoveDialog()
        {
            InitializeComponent();
        }


        public void SetItemInformation(string itemDetails)
        {
            uxItemDescription.Text = itemDetails;
        }
    }
}
