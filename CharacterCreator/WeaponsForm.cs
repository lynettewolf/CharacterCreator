using CharacterCreator.Helper_Files;
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
    public partial class WeaponsForm : Form
    {
        private bool _changesMade;
        private RemoveDialog _removeDialog = new RemoveDialog();
        
        public WeaponsForm()
        {
            InitializeComponent();
        }

        private void uxAddWeapon_Click(object sender, EventArgs e)
        {

        }

        private void uxRemoveWeapon_Click(object sender, EventArgs e)
        {
            _removeDialog.SetItemInformation("");
            if(_removeDialog.ShowDialog() == DialogResult.OK)
            {
                uxWeaponList.Items.RemoveAt(uxWeaponList.SelectedIndex);
                _changesMade = true;
                uxSaveWeapon.Enabled = true;
            }
        }

        private void uxSaveWeapon_Click(object sender, EventArgs e)
        {

        }

        private void uxWeaponList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxWeaponList.SelectedIndex != -1)
            {
                uxRemoveWeapon.Enabled = true;
            }
            else
            {
                uxRemoveWeapon.Enabled = false;
            }
        }


        private void uxAddAmmo_Click(object sender, EventArgs e)
        {

        }

        private void uxRemoveAmmo_Click(object sender, EventArgs e)
        {
            _removeDialog.SetItemInformation("");
            if (_removeDialog.ShowDialog() == DialogResult.OK)
            {
                uxAmmoList.Items.RemoveAt(uxAmmoList.SelectedIndex);
                _changesMade = true;
                uxSaveAmmo.Enabled = true;
            }
        }

        private void uxSaveAmmo_Click(object sender, EventArgs e)
        {

        }

        private void uxAmmoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxAmmoList.SelectedIndex != -1)
            {
                uxRemoveAmmo.Enabled = true;
            }
            else
            {
                uxRemoveAmmo.Enabled = false;
            }
        }
        
    }
}
