namespace SkydekortGUI
{
    partial class PersonDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonDisplay));
            this.personNameHeader = new System.Windows.Forms.Label();
            this.skydekortListBox = new System.Windows.Forms.ListBox();
            this.skydekortLabel = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.skydekortPanel = new System.Windows.Forms.Panel();
            this.bDueLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.skydekortPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // personNameHeader
            // 
            this.personNameHeader.AutoSize = true;
            this.personNameHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personNameHeader.Location = new System.Drawing.Point(454, 19);
            this.personNameHeader.Name = "personNameHeader";
            this.personNameHeader.Size = new System.Drawing.Size(213, 37);
            this.personNameHeader.TabIndex = 0;
            this.personNameHeader.Text = "Person Name";
            this.personNameHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skydekortListBox
            // 
            this.skydekortListBox.FormattingEnabled = true;
            this.skydekortListBox.ItemHeight = 20;
            this.skydekortListBox.Location = new System.Drawing.Point(12, 92);
            this.skydekortListBox.Name = "skydekortListBox";
            this.skydekortListBox.Size = new System.Drawing.Size(237, 484);
            this.skydekortListBox.TabIndex = 1;
            this.skydekortListBox.SelectedIndexChanged += new System.EventHandler(this.skydekortListBox_SelectedIndexChanged);
            // 
            // skydekortLabel
            // 
            this.skydekortLabel.AutoSize = true;
            this.skydekortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skydekortLabel.Location = new System.Drawing.Point(76, 54);
            this.skydekortLabel.Name = "skydekortLabel";
            this.skydekortLabel.Size = new System.Drawing.Size(117, 25);
            this.skydekortLabel.TabIndex = 2;
            this.skydekortLabel.Text = "Skydekort";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 578);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 30);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Åben";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(174, 578);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 30);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Slet";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(93, 578);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 30);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Ny";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // skydekortPanel
            // 
            this.skydekortPanel.BackgroundImage = global::SkydekortGUI.Properties.Resources.SkydekortBackground;
            this.skydekortPanel.Controls.Add(this.bDueLabel);
            this.skydekortPanel.Location = new System.Drawing.Point(261, 92);
            this.skydekortPanel.Name = "skydekortPanel";
            this.skydekortPanel.Size = new System.Drawing.Size(870, 485);
            this.skydekortPanel.TabIndex = 6;
            // 
            // bDueLabel
            // 
            this.bDueLabel.AutoSize = true;
            this.bDueLabel.Location = new System.Drawing.Point(11, 10);
            this.bDueLabel.Name = "bDueLabel";
            this.bDueLabel.Size = new System.Drawing.Size(70, 20);
            this.bDueLabel.TabIndex = 1;
            this.bDueLabel.Text = "Bagduer";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(1056, 583);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 30);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Gem";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // PersonDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 620);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.skydekortPanel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.skydekortLabel);
            this.Controls.Add(this.skydekortListBox);
            this.Controls.Add(this.personNameHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PersonDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonDisplay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonDisplay_FormClosing);
            this.skydekortPanel.ResumeLayout(false);
            this.skydekortPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personNameHeader;
        private System.Windows.Forms.ListBox skydekortListBox;
        private System.Windows.Forms.Label skydekortLabel;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Panel skydekortPanel;
        private System.Windows.Forms.Label bDueLabel;
        private System.Windows.Forms.Button saveButton;
    }
}