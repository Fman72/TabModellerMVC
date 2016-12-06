namespace TabModellerMVC
{
    partial class GraphicalBarsForm
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
            this.addBarTextBox = new System.Windows.Forms.RichTextBox();
            this.deleteBarButton = new System.Windows.Forms.Button();
            this.modifyBarButton = new System.Windows.Forms.Button();
            this.addBarButton = new System.Windows.Forms.Button();
            this.tabPanel = new System.Windows.Forms.Panel();
            this.loadBarsButton = new System.Windows.Forms.Button();
            this.saveBarsButton = new System.Windows.Forms.Button();
            this.loadBarsDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveBarsDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadBarsBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.deleteAllBarsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modifyBarValidationLabel
            // 
            this.modifyBarValidationLabel.AutoSize = true;
            this.modifyBarValidationLabel.Location = new System.Drawing.Point(528, 217);
            this.modifyBarValidationLabel.Name = "modifyBarValidationLabel";
            this.modifyBarValidationLabel.Size = new System.Drawing.Size(0, 13);
            this.modifyBarValidationLabel.TabIndex = 14;
            // 
            // addBarValidationLabel
            // 
            this.addBarValidationLabel.AutoSize = true;
            this.addBarValidationLabel.ForeColor = System.Drawing.Color.Red;
            this.addBarValidationLabel.Location = new System.Drawing.Point(527, 156);
            this.addBarValidationLabel.Name = "addBarValidationLabel";
            this.addBarValidationLabel.Size = new System.Drawing.Size(0, 13);
            this.addBarValidationLabel.TabIndex = 13;
            // 
            // addBarTextBox
            // 
            this.addBarTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBarTextBox.Location = new System.Drawing.Point(526, 42);
            this.addBarTextBox.Name = "addBarTextBox";
            this.addBarTextBox.Size = new System.Drawing.Size(358, 96);
            this.addBarTextBox.TabIndex = 12;
            this.addBarTextBox.Text = "";
            // 
            // deleteBarButton
            // 
            this.deleteBarButton.Location = new System.Drawing.Point(526, 253);
            this.deleteBarButton.Name = "deleteBarButton";
            this.deleteBarButton.Size = new System.Drawing.Size(122, 23);
            this.deleteBarButton.TabIndex = 11;
            this.deleteBarButton.Text = "Delete Bar";
            this.deleteBarButton.UseVisualStyleBackColor = true;
            this.deleteBarButton.Click += new System.EventHandler(this.deleteBarButton_Click);
            // 
            // modifyBarButton
            // 
            this.modifyBarButton.Location = new System.Drawing.Point(526, 184);
            this.modifyBarButton.Name = "modifyBarButton";
            this.modifyBarButton.Size = new System.Drawing.Size(122, 23);
            this.modifyBarButton.TabIndex = 10;
            this.modifyBarButton.Text = "Modify Bar";
            this.modifyBarButton.UseVisualStyleBackColor = true;
            this.modifyBarButton.Click += new System.EventHandler(this.modifyBarButton_Click);
            // 
            // addBarButton
            // 
            this.addBarButton.Location = new System.Drawing.Point(526, 13);
            this.addBarButton.Name = "addBarButton";
            this.addBarButton.Size = new System.Drawing.Size(122, 23);
            this.addBarButton.TabIndex = 9;
            this.addBarButton.Text = "Add Bar";
            this.addBarButton.UseVisualStyleBackColor = true;
            this.addBarButton.Click += new System.EventHandler(this.addBarButton_Click);
            // 
            // tabPanel
            // 
            this.tabPanel.AutoScroll = true;
            this.tabPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPanel.Location = new System.Drawing.Point(12, 12);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(508, 480);
            this.tabPanel.TabIndex = 8;
            // 
            // loadBarsButton
            // 
            this.loadBarsButton.Location = new System.Drawing.Point(531, 469);
            this.loadBarsButton.Name = "loadBarsButton";
            this.loadBarsButton.Size = new System.Drawing.Size(122, 23);
            this.loadBarsButton.TabIndex = 15;
            this.loadBarsButton.Text = "Load Bars";
            this.loadBarsButton.UseVisualStyleBackColor = true;
            this.loadBarsButton.Click += new System.EventHandler(this.loadBarsButton_Click);
            // 
            // saveBarsButton
            // 
            this.saveBarsButton.Location = new System.Drawing.Point(762, 469);
            this.saveBarsButton.Name = "saveBarsButton";
            this.saveBarsButton.Size = new System.Drawing.Size(122, 23);
            this.saveBarsButton.TabIndex = 16;
            this.saveBarsButton.Text = "Save Bars";
            this.saveBarsButton.UseVisualStyleBackColor = true;
            this.saveBarsButton.Click += new System.EventHandler(this.saveBarsButton_Click);
            // 
            // loadBarsDialog
            // 
            this.loadBarsDialog.FileName = "s";
            this.loadBarsDialog.Filter = "dat files | *.dat";
            this.loadBarsDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.loadBarsDialog_FileOk);
            // 
            // saveBarsDialog
            // 
            this.saveBarsDialog.Filter = "dat files | *.dat";
            this.saveBarsDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveBarsDialog_FileOk);
            // 
            // loadBarsBackgroundWorker
            // 
            this.loadBarsBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadBarsBackgroundWorker_DoWork);
            this.loadBarsBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loadBarsBackgroundWorker_RunWorkerCompleted);
            // 
            // deleteAllBarsButton
            // 
            this.deleteAllBarsButton.Location = new System.Drawing.Point(762, 253);
            this.deleteAllBarsButton.Name = "deleteAllBarsButton";
            this.deleteAllBarsButton.Size = new System.Drawing.Size(122, 23);
            this.deleteAllBarsButton.TabIndex = 17;
            this.deleteAllBarsButton.Text = "Delete All Bars";
            this.deleteAllBarsButton.UseVisualStyleBackColor = true;
            this.deleteAllBarsButton.Click += new System.EventHandler(this.deleteAllBarsButton_Click);
            // 
            // GraphicalBarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 504);
            this.Controls.Add(this.deleteAllBarsButton);
            this.Controls.Add(this.saveBarsButton);
            this.Controls.Add(this.loadBarsButton);
            this.Controls.Add(this.modifyBarValidationLabel);
            this.Controls.Add(this.addBarValidationLabel);
            this.Controls.Add(this.addBarTextBox);
            this.Controls.Add(this.deleteBarButton);
            this.Controls.Add(this.modifyBarButton);
            this.Controls.Add(this.addBarButton);
            this.Controls.Add(this.tabPanel);
            this.Name = "GraphicalBarsForm";
            this.Text = "Graphical Bars View";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GraphicalBarsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label modifyBarValidationLabel;
        protected System.Windows.Forms.Label addBarValidationLabel;
        protected System.Windows.Forms.RichTextBox addBarTextBox;
        protected System.Windows.Forms.Button deleteBarButton;
        protected System.Windows.Forms.Button modifyBarButton;
        protected System.Windows.Forms.Button addBarButton;
        protected System.Windows.Forms.Panel tabPanel;
        protected System.Windows.Forms.Button loadBarsButton;
        protected System.Windows.Forms.Button saveBarsButton;
        private System.Windows.Forms.OpenFileDialog loadBarsDialog;
        private System.Windows.Forms.SaveFileDialog saveBarsDialog;
        private System.ComponentModel.BackgroundWorker loadBarsBackgroundWorker;
        protected System.Windows.Forms.Button deleteAllBarsButton;
    }
}