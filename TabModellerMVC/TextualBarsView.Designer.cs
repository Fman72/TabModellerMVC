namespace TabModellerMVC
{
    partial class TextualBarsForm
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
            this.modifyBarValidationLabel = new System.Windows.Forms.Label();
            this.addBarValidationLabel = new System.Windows.Forms.Label();
            this.barsTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // modifyBarValidationLabel
            // 
            this.modifyBarValidationLabel.AutoSize = true;
            this.modifyBarValidationLabel.Location = new System.Drawing.Point(498, 244);
            this.modifyBarValidationLabel.Name = "modifyBarValidationLabel";
            this.modifyBarValidationLabel.Size = new System.Drawing.Size(0, 13);
            this.modifyBarValidationLabel.TabIndex = 20;
            // 
            // addBarValidationLabel
            // 
            this.addBarValidationLabel.AutoSize = true;
            this.addBarValidationLabel.ForeColor = System.Drawing.Color.Red;
            this.addBarValidationLabel.Location = new System.Drawing.Point(497, 183);
            this.addBarValidationLabel.Name = "addBarValidationLabel";
            this.addBarValidationLabel.Size = new System.Drawing.Size(0, 13);
            this.addBarValidationLabel.TabIndex = 19;
            // 
            // barsTextBox
            // 
            this.barsTextBox.Location = new System.Drawing.Point(12, 12);
            this.barsTextBox.Name = "barsTextBox";
            this.barsTextBox.Size = new System.Drawing.Size(842, 473);
            this.barsTextBox.TabIndex = 21;
            this.barsTextBox.Text = "";
            // 
            // TextualBarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 497);
            this.Controls.Add(this.barsTextBox);
            this.Controls.Add(this.modifyBarValidationLabel);
            this.Controls.Add(this.addBarValidationLabel);
            this.Name = "TextualBarsForm";
            this.Text = "Textual Bars View";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TextualBarsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label modifyBarValidationLabel;
        protected System.Windows.Forms.Label addBarValidationLabel;
        private System.Windows.Forms.RichTextBox barsTextBox;
    }
}