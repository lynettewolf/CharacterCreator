namespace CharacterCreator.Helper_Files
{
    partial class RemoveDialog
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
            this.uxRemoveLabel = new System.Windows.Forms.Label();
            this.uxItemDescription = new System.Windows.Forms.Label();
            this.uxYes = new System.Windows.Forms.Button();
            this.uxNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxRemoveLabel
            // 
            this.uxRemoveLabel.AutoSize = true;
            this.uxRemoveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRemoveLabel.Location = new System.Drawing.Point(32, 119);
            this.uxRemoveLabel.Name = "uxRemoveLabel";
            this.uxRemoveLabel.Size = new System.Drawing.Size(259, 16);
            this.uxRemoveLabel.TabIndex = 0;
            this.uxRemoveLabel.Text = "Are you sure you want to remove this item?";
            // 
            // uxItemDescription
            // 
            this.uxItemDescription.AutoSize = true;
            this.uxItemDescription.Location = new System.Drawing.Point(162, 39);
            this.uxItemDescription.Name = "uxItemDescription";
            this.uxItemDescription.Size = new System.Drawing.Size(0, 13);
            this.uxItemDescription.TabIndex = 1;
            // 
            // uxYes
            // 
            this.uxYes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxYes.Location = new System.Drawing.Point(54, 148);
            this.uxYes.Name = "uxYes";
            this.uxYes.Size = new System.Drawing.Size(83, 31);
            this.uxYes.TabIndex = 2;
            this.uxYes.Text = "Yes";
            this.uxYes.UseVisualStyleBackColor = true;
            // 
            // uxNo
            // 
            this.uxNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uxNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNo.Location = new System.Drawing.Point(191, 148);
            this.uxNo.Name = "uxNo";
            this.uxNo.Size = new System.Drawing.Size(83, 31);
            this.uxNo.TabIndex = 3;
            this.uxNo.Text = "No";
            this.uxNo.UseVisualStyleBackColor = true;
            // 
            // RemoveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 198);
            this.Controls.Add(this.uxNo);
            this.Controls.Add(this.uxYes);
            this.Controls.Add(this.uxItemDescription);
            this.Controls.Add(this.uxRemoveLabel);
            this.Name = "RemoveDialog";
            this.Text = "Delete Item...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxRemoveLabel;
        private System.Windows.Forms.Label uxItemDescription;
        private System.Windows.Forms.Button uxYes;
        private System.Windows.Forms.Button uxNo;
    }
}