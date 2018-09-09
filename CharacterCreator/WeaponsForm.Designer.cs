namespace CharacterCreator
{
    partial class WeaponsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxWeaponDetails = new System.Windows.Forms.TextBox();
            this.uxRemoveWeapon = new System.Windows.Forms.Button();
            this.uxModifyWeapon = new System.Windows.Forms.Button();
            this.uxWeaponsGroup = new System.Windows.Forms.GroupBox();
            this.uxWeaponList = new System.Windows.Forms.ListBox();
            this.uxAddWeapon = new System.Windows.Forms.Button();
            this.uxAmmoGroup = new System.Windows.Forms.GroupBox();
            this.uxAmmoList = new System.Windows.Forms.ListBox();
            this.uxAddAmmo = new System.Windows.Forms.Button();
            this.uxRemoveAmmo = new System.Windows.Forms.Button();
            this.uxModifyAmmo = new System.Windows.Forms.Button();
            this.uxAmmoDetails = new System.Windows.Forms.TextBox();
            this.uxWeapDetailLabel = new System.Windows.Forms.Label();
            this.uxAmmoDetailLabel = new System.Windows.Forms.Label();
            this.uxWeaponsGroup.SuspendLayout();
            this.uxAmmoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxWeaponDetails
            // 
            this.uxWeaponDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWeaponDetails.Location = new System.Drawing.Point(202, 46);
            this.uxWeaponDetails.Multiline = true;
            this.uxWeaponDetails.Name = "uxWeaponDetails";
            this.uxWeaponDetails.Size = new System.Drawing.Size(173, 110);
            this.uxWeaponDetails.TabIndex = 1;
            // 
            // uxRemoveWeapon
            // 
            this.uxRemoveWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRemoveWeapon.Location = new System.Drawing.Point(260, 162);
            this.uxRemoveWeapon.Name = "uxRemoveWeapon";
            this.uxRemoveWeapon.Size = new System.Drawing.Size(57, 23);
            this.uxRemoveWeapon.TabIndex = 2;
            this.uxRemoveWeapon.Text = "Remove";
            this.uxRemoveWeapon.UseVisualStyleBackColor = true;
            // 
            // uxModifyWeapon
            // 
            this.uxModifyWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxModifyWeapon.Location = new System.Drawing.Point(318, 162);
            this.uxModifyWeapon.Name = "uxModifyWeapon";
            this.uxModifyWeapon.Size = new System.Drawing.Size(57, 23);
            this.uxModifyWeapon.TabIndex = 3;
            this.uxModifyWeapon.Text = "Modify";
            this.uxModifyWeapon.UseVisualStyleBackColor = true;
            // 
            // uxWeaponsGroup
            // 
            this.uxWeaponsGroup.Controls.Add(this.uxWeapDetailLabel);
            this.uxWeaponsGroup.Controls.Add(this.uxRemoveWeapon);
            this.uxWeaponsGroup.Controls.Add(this.uxWeaponList);
            this.uxWeaponsGroup.Controls.Add(this.uxAddWeapon);
            this.uxWeaponsGroup.Controls.Add(this.uxModifyWeapon);
            this.uxWeaponsGroup.Controls.Add(this.uxWeaponDetails);
            this.uxWeaponsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWeaponsGroup.Location = new System.Drawing.Point(12, 12);
            this.uxWeaponsGroup.Name = "uxWeaponsGroup";
            this.uxWeaponsGroup.Size = new System.Drawing.Size(397, 197);
            this.uxWeaponsGroup.TabIndex = 5;
            this.uxWeaponsGroup.TabStop = false;
            this.uxWeaponsGroup.Text = "Weapons";
            // 
            // uxWeaponList
            // 
            this.uxWeaponList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWeaponList.FormattingEnabled = true;
            this.uxWeaponList.ItemHeight = 16;
            this.uxWeaponList.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth",
            "Fifth"});
            this.uxWeaponList.Location = new System.Drawing.Point(15, 21);
            this.uxWeaponList.Name = "uxWeaponList";
            this.uxWeaponList.Size = new System.Drawing.Size(164, 164);
            this.uxWeaponList.TabIndex = 0;
            // 
            // uxAddWeapon
            // 
            this.uxAddWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddWeapon.Location = new System.Drawing.Point(202, 162);
            this.uxAddWeapon.Name = "uxAddWeapon";
            this.uxAddWeapon.Size = new System.Drawing.Size(57, 23);
            this.uxAddWeapon.TabIndex = 6;
            this.uxAddWeapon.Text = "Add";
            this.uxAddWeapon.UseVisualStyleBackColor = true;
            this.uxAddWeapon.Click += new System.EventHandler(this.uxAddWeapon_Click);
            // 
            // uxAmmoGroup
            // 
            this.uxAmmoGroup.Controls.Add(this.uxAmmoDetailLabel);
            this.uxAmmoGroup.Controls.Add(this.uxRemoveAmmo);
            this.uxAmmoGroup.Controls.Add(this.uxAmmoList);
            this.uxAmmoGroup.Controls.Add(this.uxModifyAmmo);
            this.uxAmmoGroup.Controls.Add(this.uxAddAmmo);
            this.uxAmmoGroup.Controls.Add(this.uxAmmoDetails);
            this.uxAmmoGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAmmoGroup.Location = new System.Drawing.Point(12, 228);
            this.uxAmmoGroup.Name = "uxAmmoGroup";
            this.uxAmmoGroup.Size = new System.Drawing.Size(397, 197);
            this.uxAmmoGroup.TabIndex = 7;
            this.uxAmmoGroup.TabStop = false;
            this.uxAmmoGroup.Text = "Ammunition";
            // 
            // uxAmmoList
            // 
            this.uxAmmoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAmmoList.FormattingEnabled = true;
            this.uxAmmoList.ItemHeight = 16;
            this.uxAmmoList.Items.AddRange(new object[] {
            "Bullets",
            "Arrows",
            "Darts",
            "Throwing Knives"});
            this.uxAmmoList.Location = new System.Drawing.Point(15, 21);
            this.uxAmmoList.Name = "uxAmmoList";
            this.uxAmmoList.Size = new System.Drawing.Size(164, 164);
            this.uxAmmoList.TabIndex = 0;
            // 
            // uxAddAmmo
            // 
            this.uxAddAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddAmmo.Location = new System.Drawing.Point(202, 159);
            this.uxAddAmmo.Name = "uxAddAmmo";
            this.uxAddAmmo.Size = new System.Drawing.Size(57, 23);
            this.uxAddAmmo.TabIndex = 6;
            this.uxAddAmmo.Text = "Add";
            this.uxAddAmmo.UseVisualStyleBackColor = true;
            // 
            // uxRemoveAmmo
            // 
            this.uxRemoveAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRemoveAmmo.Location = new System.Drawing.Point(260, 159);
            this.uxRemoveAmmo.Name = "uxRemoveAmmo";
            this.uxRemoveAmmo.Size = new System.Drawing.Size(57, 23);
            this.uxRemoveAmmo.TabIndex = 8;
            this.uxRemoveAmmo.Text = "Remove";
            this.uxRemoveAmmo.UseVisualStyleBackColor = true;
            // 
            // uxModifyAmmo
            // 
            this.uxModifyAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxModifyAmmo.Location = new System.Drawing.Point(318, 159);
            this.uxModifyAmmo.Name = "uxModifyAmmo";
            this.uxModifyAmmo.Size = new System.Drawing.Size(57, 23);
            this.uxModifyAmmo.TabIndex = 9;
            this.uxModifyAmmo.Text = "Modify";
            this.uxModifyAmmo.UseVisualStyleBackColor = true;
            // 
            // uxAmmoDetails
            // 
            this.uxAmmoDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAmmoDetails.Location = new System.Drawing.Point(202, 43);
            this.uxAmmoDetails.Multiline = true;
            this.uxAmmoDetails.Name = "uxAmmoDetails";
            this.uxAmmoDetails.Size = new System.Drawing.Size(173, 110);
            this.uxAmmoDetails.TabIndex = 7;
            // 
            // uxWeapDetailLabel
            // 
            this.uxWeapDetailLabel.AutoSize = true;
            this.uxWeapDetailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWeapDetailLabel.Location = new System.Drawing.Point(203, 21);
            this.uxWeapDetailLabel.Name = "uxWeapDetailLabel";
            this.uxWeapDetailLabel.Size = new System.Drawing.Size(56, 16);
            this.uxWeapDetailLabel.TabIndex = 7;
            this.uxWeapDetailLabel.Text = "Details :";
            // 
            // uxAmmoDetailLabel
            // 
            this.uxAmmoDetailLabel.AutoSize = true;
            this.uxAmmoDetailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAmmoDetailLabel.Location = new System.Drawing.Point(203, 21);
            this.uxAmmoDetailLabel.Name = "uxAmmoDetailLabel";
            this.uxAmmoDetailLabel.Size = new System.Drawing.Size(56, 16);
            this.uxAmmoDetailLabel.TabIndex = 10;
            this.uxAmmoDetailLabel.Text = "Details :";
            // 
            // WeaponsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 454);
            this.Controls.Add(this.uxAmmoGroup);
            this.Controls.Add(this.uxWeaponsGroup);
            this.Name = "WeaponsForm";
            this.Text = "WeaponsInterface";
            this.uxWeaponsGroup.ResumeLayout(false);
            this.uxWeaponsGroup.PerformLayout();
            this.uxAmmoGroup.ResumeLayout(false);
            this.uxAmmoGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox uxWeaponDetails;
        private System.Windows.Forms.Button uxRemoveWeapon;
        private System.Windows.Forms.Button uxModifyWeapon;
        private System.Windows.Forms.GroupBox uxWeaponsGroup;
        private System.Windows.Forms.ListBox uxWeaponList;
        private System.Windows.Forms.Button uxAddWeapon;
        private System.Windows.Forms.GroupBox uxAmmoGroup;
        private System.Windows.Forms.ListBox uxAmmoList;
        private System.Windows.Forms.Button uxAddAmmo;
        private System.Windows.Forms.Button uxRemoveAmmo;
        private System.Windows.Forms.Button uxModifyAmmo;
        private System.Windows.Forms.TextBox uxAmmoDetails;
        private System.Windows.Forms.Label uxWeapDetailLabel;
        private System.Windows.Forms.Label uxAmmoDetailLabel;
    }
}