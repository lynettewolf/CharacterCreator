namespace CharacterCreator
{
    partial class UserInterface
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
            this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.uxFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.uxHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.uxPlayerName = new System.Windows.Forms.TextBox();
            this.uxCharacterName = new System.Windows.Forms.TextBox();
            this.uxLevel = new System.Windows.Forms.NumericUpDown();
            this.uxAlignment = new System.Windows.Forms.ComboBox();
            this.uxRace = new System.Windows.Forms.ComboBox();
            this.uxSize = new System.Windows.Forms.ComboBox();
            this.uxGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uxWeight = new System.Windows.Forms.NumericUpDown();
            this.uxHeightFeet = new System.Windows.Forms.NumericUpDown();
            this.uxHeightInches = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uxAddBackStory = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uxAddPhysicalDescription = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.uxColorDialog = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.uxEyeButton = new System.Windows.Forms.Button();
            this.uxHairButton = new System.Windows.Forms.Button();
            this.uxSkinButton = new System.Windows.Forms.Button();
            this.uxMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxHeightFeet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxHeightInches)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFileButton,
            this.uxHelp});
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(567, 24);
            this.uxMenuStrip.TabIndex = 0;
            this.uxMenuStrip.Text = "menuStrip1";
            // 
            // uxFileButton
            // 
            this.uxFileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenButton,
            this.uxSaveButton});
            this.uxFileButton.Name = "uxFileButton";
            this.uxFileButton.Size = new System.Drawing.Size(37, 20);
            this.uxFileButton.Text = "File";
            // 
            // uxOpenButton
            // 
            this.uxOpenButton.Name = "uxOpenButton";
            this.uxOpenButton.Size = new System.Drawing.Size(112, 22);
            this.uxOpenButton.Text = "Open";
            // 
            // uxSaveButton
            // 
            this.uxSaveButton.Name = "uxSaveButton";
            this.uxSaveButton.Size = new System.Drawing.Size(112, 22);
            this.uxSaveButton.Text = "Save as";
            // 
            // uxHelp
            // 
            this.uxHelp.Name = "uxHelp";
            this.uxHelp.Size = new System.Drawing.Size(44, 20);
            this.uxHelp.Text = "Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Character name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alignment: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Level: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(127, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Race:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Size:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Gender:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Height:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(127, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Weight:";
            // 
            // uxPlayerName
            // 
            this.uxPlayerName.Location = new System.Drawing.Point(370, 32);
            this.uxPlayerName.Name = "uxPlayerName";
            this.uxPlayerName.Size = new System.Drawing.Size(169, 20);
            this.uxPlayerName.TabIndex = 15;
            // 
            // uxCharacterName
            // 
            this.uxCharacterName.Location = new System.Drawing.Point(119, 32);
            this.uxCharacterName.Name = "uxCharacterName";
            this.uxCharacterName.Size = new System.Drawing.Size(160, 20);
            this.uxCharacterName.TabIndex = 16;
            // 
            // uxLevel
            // 
            this.uxLevel.Location = new System.Drawing.Point(59, 23);
            this.uxLevel.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.uxLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxLevel.Name = "uxLevel";
            this.uxLevel.Size = new System.Drawing.Size(37, 20);
            this.uxLevel.TabIndex = 17;
            this.uxLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxAlignment
            // 
            this.uxAlignment.FormattingEnabled = true;
            this.uxAlignment.Items.AddRange(new object[] {
            "True Neutral",
            "Lawful Good",
            "Lawful Evil",
            "Neutral Good",
            "Neutral Evil",
            "Chaotic Good",
            "Chaotic Evil"});
            this.uxAlignment.Location = new System.Drawing.Point(181, 22);
            this.uxAlignment.Name = "uxAlignment";
            this.uxAlignment.Size = new System.Drawing.Size(82, 21);
            this.uxAlignment.TabIndex = 18;
            // 
            // uxRace
            // 
            this.uxRace.FormattingEnabled = true;
            this.uxRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half-Elf",
            "Half-Orc",
            "Halfling",
            "Human",
            "Aasimar",
            "Catfolk",
            "Dhampir",
            "Drow",
            "Fetchling",
            "Gnoll",
            "Goblin",
            "Hobgoblin",
            "Ifrit",
            "Kobold",
            "Lizardfolk",
            "Monkey Goblin",
            "Orc",
            "Oread",
            "Ratfolk",
            "Sylph",
            "Tengu",
            "Tiefling",
            "Undine",
            "Changeling",
            "Duergar",
            "Gillman",
            "Grippli",
            "Kitsune",
            "Merfolk",
            "Nagaji",
            "Samsarans",
            "Skinwalker",
            "Strix",
            "Suli",
            "Svirfneblin",
            "Triaxian",
            "Vanara",
            "Vishkanya",
            "Wayang"});
            this.uxRace.Location = new System.Drawing.Point(172, 57);
            this.uxRace.Name = "uxRace";
            this.uxRace.Size = new System.Drawing.Size(91, 21);
            this.uxRace.TabIndex = 20;
            // 
            // uxSize
            // 
            this.uxSize.FormattingEnabled = true;
            this.uxSize.Items.AddRange(new object[] {
            "Fine",
            "Diminutive",
            "Tiny",
            "Small",
            "Medium",
            "Large",
            "Huge",
            "Gargantuan",
            "Colossal"});
            this.uxSize.Location = new System.Drawing.Point(46, 57);
            this.uxSize.Name = "uxSize";
            this.uxSize.Size = new System.Drawing.Size(75, 21);
            this.uxSize.TabIndex = 21;
            // 
            // uxGender
            // 
            this.uxGender.FormattingEnabled = true;
            this.uxGender.Items.AddRange(new object[] {
            "Other",
            "Male",
            "Female"});
            this.uxGender.Location = new System.Drawing.Point(62, 91);
            this.uxGender.Name = "uxGender";
            this.uxGender.Size = new System.Drawing.Size(59, 21);
            this.uxGender.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "lbs";
            // 
            // uxWeight
            // 
            this.uxWeight.Location = new System.Drawing.Point(181, 93);
            this.uxWeight.Name = "uxWeight";
            this.uxWeight.Size = new System.Drawing.Size(58, 20);
            this.uxWeight.TabIndex = 25;
            // 
            // uxHeightFeet
            // 
            this.uxHeightFeet.Location = new System.Drawing.Point(59, 124);
            this.uxHeightFeet.Name = "uxHeightFeet";
            this.uxHeightFeet.Size = new System.Drawing.Size(44, 20);
            this.uxHeightFeet.TabIndex = 26;
            // 
            // uxHeightInches
            // 
            this.uxHeightInches.Location = new System.Drawing.Point(120, 124);
            this.uxHeightInches.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.uxHeightInches.Name = "uxHeightInches";
            this.uxHeightInches.Size = new System.Drawing.Size(44, 20);
            this.uxHeightInches.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "ft.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(163, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "in.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uxSkinButton);
            this.groupBox1.Controls.Add(this.uxHairButton);
            this.groupBox1.Controls.Add(this.uxEyeButton);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.uxAddPhysicalDescription);
            this.groupBox1.Controls.Add(this.uxAddBackStory);
            this.groupBox1.Location = new System.Drawing.Point(301, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 155);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra Character Traits";
            // 
            // uxAddBackStory
            // 
            this.uxAddBackStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddBackStory.Location = new System.Drawing.Point(9, 23);
            this.uxAddBackStory.Name = "uxAddBackStory";
            this.uxAddBackStory.Size = new System.Drawing.Size(105, 51);
            this.uxAddBackStory.TabIndex = 0;
            this.uxAddBackStory.Text = "Backstory";
            this.uxAddBackStory.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uxAlignment);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.uxLevel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.uxHeightInches);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.uxHeightFeet);
            this.groupBox2.Controls.Add(this.uxSize);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.uxWeight);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.uxGender);
            this.groupBox2.Controls.Add(this.uxRace);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(16, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 155);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Character Traits";
            // 
            // uxAddPhysicalDescription
            // 
            this.uxAddPhysicalDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddPhysicalDescription.Location = new System.Drawing.Point(133, 23);
            this.uxAddPhysicalDescription.Name = "uxAddPhysicalDescription";
            this.uxAddPhysicalDescription.Size = new System.Drawing.Size(105, 50);
            this.uxAddPhysicalDescription.TabIndex = 1;
            this.uxAddPhysicalDescription.Text = "Physical Description";
            this.uxAddPhysicalDescription.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Deity:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(103, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Homeland:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 20);
            this.textBox2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(137, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 20);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Location = new System.Drawing.Point(217, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 20);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // uxEyeButton
            // 
            this.uxEyeButton.Location = new System.Drawing.Point(9, 121);
            this.uxEyeButton.Name = "uxEyeButton";
            this.uxEyeButton.Size = new System.Drawing.Size(43, 23);
            this.uxEyeButton.TabIndex = 12;
            this.uxEyeButton.Text = "Eyes:";
            this.uxEyeButton.UseVisualStyleBackColor = true;
            // 
            // uxHairButton
            // 
            this.uxHairButton.Location = new System.Drawing.Point(90, 122);
            this.uxHairButton.Name = "uxHairButton";
            this.uxHairButton.Size = new System.Drawing.Size(43, 23);
            this.uxHairButton.TabIndex = 13;
            this.uxHairButton.Text = "Hair:";
            this.uxHairButton.UseVisualStyleBackColor = true;
            // 
            // uxSkinButton
            // 
            this.uxSkinButton.Location = new System.Drawing.Point(168, 121);
            this.uxSkinButton.Name = "uxSkinButton";
            this.uxSkinButton.Size = new System.Drawing.Size(43, 23);
            this.uxSkinButton.TabIndex = 14;
            this.uxSkinButton.Text = "Skin:";
            this.uxSkinButton.UseVisualStyleBackColor = true;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 425);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uxCharacterName);
            this.Controls.Add(this.uxPlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxMenuStrip);
            this.MainMenuStrip = this.uxMenuStrip;
            this.Name = "UserInterface";
            this.Text = "Character Creator";
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxHeightFeet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxHeightInches)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem uxFileButton;
        private System.Windows.Forms.ToolStripMenuItem uxOpenButton;
        private System.Windows.Forms.ToolStripMenuItem uxSaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox uxPlayerName;
        private System.Windows.Forms.TextBox uxCharacterName;
        private System.Windows.Forms.NumericUpDown uxLevel;
        private System.Windows.Forms.ComboBox uxAlignment;
        private System.Windows.Forms.ComboBox uxRace;
        private System.Windows.Forms.ComboBox uxSize;
        private System.Windows.Forms.ComboBox uxGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown uxWeight;
        private System.Windows.Forms.NumericUpDown uxHeightFeet;
        private System.Windows.Forms.NumericUpDown uxHeightInches;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem uxHelp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button uxAddBackStory;
        private System.Windows.Forms.Button uxSkinButton;
        private System.Windows.Forms.Button uxHairButton;
        private System.Windows.Forms.Button uxEyeButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button uxAddPhysicalDescription;
        private System.Windows.Forms.ColorDialog uxColorDialog;
    }
}

