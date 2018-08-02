namespace Extrathicc
{
    partial class Translator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Translator));
            this.translatorLabel = new System.Windows.Forms.Label();
            this.englishTextBox = new System.Windows.Forms.TextBox();
            this.translateButton = new System.Windows.Forms.Button();
            this.extrathiccTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // translatorLabel
            // 
            this.translatorLabel.AutoSize = true;
            this.translatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translatorLabel.Location = new System.Drawing.Point(225, 9);
            this.translatorLabel.Name = "translatorLabel";
            this.translatorLabel.Size = new System.Drawing.Size(313, 25);
            this.translatorLabel.TabIndex = 0;
            this.translatorLabel.Text = "EXTRATHICC TRANSLATOR";
            // 
            // englishTextBox
            // 
            this.englishTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.englishTextBox.Location = new System.Drawing.Point(20, 48);
            this.englishTextBox.Multiline = true;
            this.englishTextBox.Name = "englishTextBox";
            this.englishTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.englishTextBox.Size = new System.Drawing.Size(740, 146);
            this.englishTextBox.TabIndex = 1;
            this.englishTextBox.Text = "enter your english text here";
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(278, 200);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(208, 53);
            this.translateButton.TabIndex = 2;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // extrathiccTextBox
            // 
            this.extrathiccTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.extrathiccTextBox.Location = new System.Drawing.Point(20, 259);
            this.extrathiccTextBox.Multiline = true;
            this.extrathiccTextBox.Name = "extrathiccTextBox";
            this.extrathiccTextBox.ReadOnly = true;
            this.extrathiccTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.extrathiccTextBox.Size = new System.Drawing.Size(740, 146);
            this.extrathiccTextBox.TabIndex = 3;
            this.extrathiccTextBox.Text = "enter your extrathicc text here";
            // 
            // Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.extrathiccTextBox);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.englishTextBox);
            this.Controls.Add(this.translatorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Translator";
            this.Text = "Extrathicc translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label translatorLabel;
        private System.Windows.Forms.TextBox englishTextBox;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.TextBox extrathiccTextBox;
    }
}

