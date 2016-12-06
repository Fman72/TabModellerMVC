namespace TabModellerMVC
{
    partial class FilteredBarsView
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
            this.tabPanel = new System.Windows.Forms.Panel();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.AutoScroll = true;
            this.tabPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPanel.Location = new System.Drawing.Point(12, 10);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(675, 480);
            this.tabPanel.TabIndex = 9;
            // 
            // filterComboBox
            // 
            this.filterComboBox.DisplayMember = "Simple Bars";
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Simple Bars",
            "Complex Bars",
            "Bars With Tags"});
            this.filterComboBox.Location = new System.Drawing.Point(693, 10);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(144, 21);
            this.filterComboBox.TabIndex = 10;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // FilteredBarsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 502);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.tabPanel);
            this.Name = "FilteredBarsView";
            this.Text = "Filtered Bars View";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FilteredBarsView_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel tabPanel;
        private System.Windows.Forms.ComboBox filterComboBox;
    }
}