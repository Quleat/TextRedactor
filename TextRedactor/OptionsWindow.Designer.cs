namespace TextRedactor
{
    partial class OptionsWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.addDeclarationBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveDateBox = new System.Windows.Forms.CheckBox();
            this.saveFontBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font:";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(49, 23);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addDeclarationBox
            // 
            this.addDeclarationBox.AutoSize = true;
            this.addDeclarationBox.Location = new System.Drawing.Point(15, 52);
            this.addDeclarationBox.Name = "addDeclarationBox";
            this.addDeclarationBox.Size = new System.Drawing.Size(146, 17);
            this.addDeclarationBox.TabIndex = 3;
            this.addDeclarationBox.Text = "Add declaration to the file";
            this.addDeclarationBox.UseVisualStyleBackColor = true;
            this.addDeclarationBox.CheckedChanged += new System.EventHandler(this.addDeclarationBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.saveDateBox);
            this.panel1.Controls.Add(this.saveFontBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(236, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 220);
            this.panel1.TabIndex = 4;
            // 
            // saveDateBox
            // 
            this.saveDateBox.AutoSize = true;
            this.saveDateBox.Enabled = false;
            this.saveDateBox.Location = new System.Drawing.Point(8, 64);
            this.saveDateBox.Name = "saveDateBox";
            this.saveDateBox.Size = new System.Drawing.Size(141, 17);
            this.saveDateBox.TabIndex = 2;
            this.saveDateBox.Text = "Save creation time in file";
            this.saveDateBox.UseVisualStyleBackColor = true;
            this.saveDateBox.CheckedChanged += new System.EventHandler(this.saveDateBox_CheckedChanged);
            // 
            // saveFontBox
            // 
            this.saveFontBox.AutoSize = true;
            this.saveFontBox.Enabled = false;
            this.saveFontBox.Location = new System.Drawing.Point(8, 40);
            this.saveFontBox.Name = "saveFontBox";
            this.saveFontBox.Size = new System.Drawing.Size(99, 17);
            this.saveFontBox.TabIndex = 1;
            this.saveFontBox.Text = "Save font in file";
            this.saveFontBox.UseVisualStyleBackColor = true;
            this.saveFontBox.CheckedChanged += new System.EventHandler(this.saveFontBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Saving files";
            // 
            // OptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 348);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addDeclarationBox);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.label1);
            this.Name = "OptionsWindow";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.CheckBox addDeclarationBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox saveDateBox;
        private System.Windows.Forms.CheckBox saveFontBox;
        private System.Windows.Forms.Label label2;
    }
}