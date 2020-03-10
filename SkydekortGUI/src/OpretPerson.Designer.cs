namespace SkydekortGUI
{
    partial class OpretPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpretPerson));
            this.createPersonHeader = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.UIDTextbox = new System.Windows.Forms.TextBox();
            this.uIDLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPersonHeader
            // 
            this.createPersonHeader.AutoSize = true;
            this.createPersonHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPersonHeader.Location = new System.Drawing.Point(105, 9);
            this.createPersonHeader.Name = "createPersonHeader";
            this.createPersonHeader.Size = new System.Drawing.Size(151, 25);
            this.createPersonHeader.TabIndex = 0;
            this.createPersonHeader.Text = "Opret Person";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(7, 72);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(67, 20);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "Fornavn";
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(93, 69);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(251, 26);
            this.firstNameTextbox.TabIndex = 2;
            this.firstNameTextbox.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(93, 101);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(251, 26);
            this.lastNameTextbox.TabIndex = 4;
            this.lastNameTextbox.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(7, 104);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(78, 20);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Efternavn";
            // 
            // UIDTextbox
            // 
            this.UIDTextbox.Location = new System.Drawing.Point(93, 133);
            this.UIDTextbox.MaxLength = 8;
            this.UIDTextbox.Name = "UIDTextbox";
            this.UIDTextbox.Size = new System.Drawing.Size(251, 26);
            this.UIDTextbox.TabIndex = 6;
            this.UIDTextbox.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            this.UIDTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UIDTextbox_KeyPress);
            // 
            // uIDLabel
            // 
            this.uIDLabel.AutoSize = true;
            this.uIDLabel.Location = new System.Drawing.Point(7, 136);
            this.uIDLabel.Name = "uIDLabel";
            this.uIDLabel.Size = new System.Drawing.Size(62, 20);
            this.uIDLabel.TabIndex = 5;
            this.uIDLabel.Text = "Unik ID";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(110, 176);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(146, 42);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Opret Person";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // OpretPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 242);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.UIDTextbox);
            this.Controls.Add(this.uIDLabel);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.createPersonHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OpretPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpretPerson";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpretPerson_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPersonHeader;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox UIDTextbox;
        private System.Windows.Forms.Label uIDLabel;
        private System.Windows.Forms.Button createButton;
    }
}