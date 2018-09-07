namespace CharacterCreator
{
    partial class LanguageInterface
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
            this.uxLanguageList = new System.Windows.Forms.CheckedListBox();
            this.uxCancelLanguages = new System.Windows.Forms.Button();
            this.uxSaveLanguages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLanguageList
            // 
            this.uxLanguageList.CheckOnClick = true;
            this.uxLanguageList.ColumnWidth = 150;
            this.uxLanguageList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLanguageList.FormattingEnabled = true;
            this.uxLanguageList.Items.AddRange(new object[] {
            "Aboleth",
            "Abyssal",
            "Aklo",
            "Aquan",
            "Auran",
            "Boggard",
            "Celestial",
            "Common",
            "Cyclops",
            "D\'ziriak",
            "Dark Folk",
            "Draconic",
            "Drow",
            "Druidic",
            "Dwarven",
            "Elven",
            "Giant",
            "Gnoll",
            "Gnome",
            "Goblin",
            "Grippli",
            "Halfling",
            "Ignan",
            "Infernal",
            "Necril",
            "Orc",
            "Protean",
            "Sphinx",
            "Sylvan",
            "Tengu",
            "Terran",
            "Treant",
            "Undercommon",
            "Vegepygmy"});
            this.uxLanguageList.Location = new System.Drawing.Point(12, 12);
            this.uxLanguageList.Name = "uxLanguageList";
            this.uxLanguageList.Size = new System.Drawing.Size(156, 191);
            this.uxLanguageList.Sorted = true;
            this.uxLanguageList.TabIndex = 0;
            this.uxLanguageList.ThreeDCheckBoxes = true;
            // 
            // uxCancelLanguages
            // 
            this.uxCancelLanguages.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uxCancelLanguages.Location = new System.Drawing.Point(93, 215);
            this.uxCancelLanguages.Name = "uxCancelLanguages";
            this.uxCancelLanguages.Size = new System.Drawing.Size(75, 23);
            this.uxCancelLanguages.TabIndex = 1;
            this.uxCancelLanguages.Text = "Cancel";
            this.uxCancelLanguages.UseVisualStyleBackColor = true;
            // 
            // uxSaveLanguages
            // 
            this.uxSaveLanguages.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxSaveLanguages.Location = new System.Drawing.Point(12, 215);
            this.uxSaveLanguages.Name = "uxSaveLanguages";
            this.uxSaveLanguages.Size = new System.Drawing.Size(75, 23);
            this.uxSaveLanguages.TabIndex = 2;
            this.uxSaveLanguages.Text = "Save";
            this.uxSaveLanguages.UseVisualStyleBackColor = true;
            // 
            // LanguageInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 250);
            this.Controls.Add(this.uxSaveLanguages);
            this.Controls.Add(this.uxCancelLanguages);
            this.Controls.Add(this.uxLanguageList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LanguageInterface";
            this.Text = "Languages";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox uxLanguageList;
        private System.Windows.Forms.Button uxCancelLanguages;
        private System.Windows.Forms.Button uxSaveLanguages;
    }
}