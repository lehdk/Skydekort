namespace SkydekortGUI
{
    partial class SkydekortOpenPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkydekortOpenPerson));
            this.personListBox = new System.Windows.Forms.ListBox();
            this.openPerson = new System.Windows.Forms.Button();
            this.personHeader = new System.Windows.Forms.Label();
            this.createPerson = new System.Windows.Forms.Button();
            this.deletePerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personListBox
            // 
            this.personListBox.FormattingEnabled = true;
            this.personListBox.ItemHeight = 20;
            this.personListBox.Location = new System.Drawing.Point(22, 48);
            this.personListBox.Name = "personListBox";
            this.personListBox.Size = new System.Drawing.Size(279, 344);
            this.personListBox.TabIndex = 0;
            this.personListBox.SelectedIndexChanged += new System.EventHandler(this.personListBox_SelectedIndexChanged);
            // 
            // openPerson
            // 
            this.openPerson.Location = new System.Drawing.Point(22, 398);
            this.openPerson.Name = "openPerson";
            this.openPerson.Size = new System.Drawing.Size(129, 37);
            this.openPerson.TabIndex = 1;
            this.openPerson.Text = "Åben Person";
            this.openPerson.UseVisualStyleBackColor = true;
            this.openPerson.Click += new System.EventHandler(this.openPerson_Click);
            // 
            // personHeader
            // 
            this.personHeader.AutoSize = true;
            this.personHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personHeader.Location = new System.Drawing.Point(104, 20);
            this.personHeader.Name = "personHeader";
            this.personHeader.Size = new System.Drawing.Size(107, 25);
            this.personHeader.TabIndex = 2;
            this.personHeader.Text = "Personer";
            // 
            // createPerson
            // 
            this.createPerson.Location = new System.Drawing.Point(172, 398);
            this.createPerson.Name = "createPerson";
            this.createPerson.Size = new System.Drawing.Size(129, 37);
            this.createPerson.TabIndex = 3;
            this.createPerson.Text = "Opret Person";
            this.createPerson.UseVisualStyleBackColor = true;
            this.createPerson.Click += new System.EventHandler(this.createPerson_Click);
            // 
            // deletePerson
            // 
            this.deletePerson.Location = new System.Drawing.Point(172, 441);
            this.deletePerson.Name = "deletePerson";
            this.deletePerson.Size = new System.Drawing.Size(129, 37);
            this.deletePerson.TabIndex = 4;
            this.deletePerson.Text = "Slet Person";
            this.deletePerson.UseVisualStyleBackColor = true;
            this.deletePerson.Click += new System.EventHandler(this.deletePerson_Click);
            // 
            // SkydekortOpenPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 484);
            this.Controls.Add(this.deletePerson);
            this.Controls.Add(this.createPerson);
            this.Controls.Add(this.personHeader);
            this.Controls.Add(this.openPerson);
            this.Controls.Add(this.personListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SkydekortOpenPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skydekort DEMO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox personListBox;
        private System.Windows.Forms.Button openPerson;
        private System.Windows.Forms.Label personHeader;
        private System.Windows.Forms.Button createPerson;
        private System.Windows.Forms.Button deletePerson;
    }
}

