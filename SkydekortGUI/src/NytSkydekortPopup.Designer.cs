namespace SkydekortGUI
{
    partial class NytSkydekortPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NytSkydekortPopup));
            this.newCardHeader = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.titelTextBox = new System.Windows.Forms.TextBox();
            this.titelLabel = new System.Windows.Forms.Label();
            this.dateAsTitelCheckBox = new System.Windows.Forms.CheckBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.seriesSelecter = new System.Windows.Forms.ComboBox();
            this.seriesTypeLabel = new System.Windows.Forms.Label();
            this.serieBDuerLabel = new System.Windows.Forms.Label();
            this.serieVDuerLabel = new System.Windows.Forms.Label();
            this.serieSDuerLabel = new System.Windows.Forms.Label();
            this.serieHDuerLabel = new System.Windows.Forms.Label();
            this.bDuePicker = new System.Windows.Forms.NumericUpDown();
            this.vDuePicker = new System.Windows.Forms.NumericUpDown();
            this.sDuePicker = new System.Windows.Forms.NumericUpDown();
            this.hDuePicker = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bDuePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDuePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDuePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDuePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // newCardHeader
            // 
            this.newCardHeader.AutoSize = true;
            this.newCardHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCardHeader.Location = new System.Drawing.Point(12, 9);
            this.newCardHeader.Name = "newCardHeader";
            this.newCardHeader.Size = new System.Drawing.Size(174, 29);
            this.newCardHeader.TabIndex = 0;
            this.newCardHeader.Text = "Nyt Skydekort";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(101, 398);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(105, 36);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Opret";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // titelTextBox
            // 
            this.titelTextBox.Location = new System.Drawing.Point(101, 62);
            this.titelTextBox.Name = "titelTextBox";
            this.titelTextBox.Size = new System.Drawing.Size(309, 26);
            this.titelTextBox.TabIndex = 2;
            // 
            // titelLabel
            // 
            this.titelLabel.AutoSize = true;
            this.titelLabel.Location = new System.Drawing.Point(6, 65);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(38, 20);
            this.titelLabel.TabIndex = 3;
            this.titelLabel.Text = "Titel";
            // 
            // dateAsTitelCheckBox
            // 
            this.dateAsTitelCheckBox.AutoSize = true;
            this.dateAsTitelCheckBox.Location = new System.Drawing.Point(284, 94);
            this.dateAsTitelCheckBox.Name = "dateAsTitelCheckBox";
            this.dateAsTitelCheckBox.Size = new System.Drawing.Size(126, 24);
            this.dateAsTitelCheckBox.TabIndex = 4;
            this.dateAsTitelCheckBox.Text = "Dato som titel";
            this.dateAsTitelCheckBox.UseVisualStyleBackColor = true;
            this.dateAsTitelCheckBox.CheckedChanged += new System.EventHandler(this.dateAsTitelCheckBox_CheckedChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(6, 95);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 20);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "Dato";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(101, 93);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(170, 26);
            this.dateTimePicker.TabIndex = 6;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionTextBox.Location = new System.Drawing.Point(101, 126);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(309, 133);
            this.DescriptionTextBox.TabIndex = 7;
            this.DescriptionTextBox.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(6, 129);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Beskrivelse";
            // 
            // seriesSelecter
            // 
            this.seriesSelecter.FormattingEnabled = true;
            this.seriesSelecter.Items.AddRange(new object[] {
            "24 serie",
            "32 serie",
            "40 serie",
            "speciel"});
            this.seriesSelecter.Location = new System.Drawing.Point(101, 265);
            this.seriesSelecter.Name = "seriesSelecter";
            this.seriesSelecter.Size = new System.Drawing.Size(105, 28);
            this.seriesSelecter.TabIndex = 9;
            this.seriesSelecter.SelectedIndexChanged += new System.EventHandler(this.seriesSelecter_SelectedIndexChanged);
            // 
            // seriesTypeLabel
            // 
            this.seriesTypeLabel.AutoSize = true;
            this.seriesTypeLabel.Location = new System.Drawing.Point(6, 268);
            this.seriesTypeLabel.Name = "seriesTypeLabel";
            this.seriesTypeLabel.Size = new System.Drawing.Size(76, 20);
            this.seriesTypeLabel.TabIndex = 10;
            this.seriesTypeLabel.Text = "Serietype";
            // 
            // serieBDuerLabel
            // 
            this.serieBDuerLabel.AutoSize = true;
            this.serieBDuerLabel.Location = new System.Drawing.Point(245, 270);
            this.serieBDuerLabel.Name = "serieBDuerLabel";
            this.serieBDuerLabel.Size = new System.Drawing.Size(70, 20);
            this.serieBDuerLabel.TabIndex = 11;
            this.serieBDuerLabel.Text = "Bagduer";
            // 
            // serieVDuerLabel
            // 
            this.serieVDuerLabel.AutoSize = true;
            this.serieVDuerLabel.Location = new System.Drawing.Point(245, 303);
            this.serieVDuerLabel.Name = "serieVDuerLabel";
            this.serieVDuerLabel.Size = new System.Drawing.Size(97, 20);
            this.serieVDuerLabel.TabIndex = 12;
            this.serieVDuerLabel.Text = "Venstreduer";
            // 
            // serieSDuerLabel
            // 
            this.serieSDuerLabel.AutoSize = true;
            this.serieSDuerLabel.Location = new System.Drawing.Point(245, 335);
            this.serieSDuerLabel.Name = "serieSDuerLabel";
            this.serieSDuerLabel.Size = new System.Drawing.Size(81, 20);
            this.serieSDuerLabel.TabIndex = 13;
            this.serieSDuerLabel.Text = "Spidsduer";
            // 
            // serieHDuerLabel
            // 
            this.serieHDuerLabel.AutoSize = true;
            this.serieHDuerLabel.Location = new System.Drawing.Point(245, 367);
            this.serieHDuerLabel.Name = "serieHDuerLabel";
            this.serieHDuerLabel.Size = new System.Drawing.Size(79, 20);
            this.serieHDuerLabel.TabIndex = 14;
            this.serieHDuerLabel.Text = "Højreduer";
            // 
            // bDuePicker
            // 
            this.bDuePicker.Location = new System.Drawing.Point(348, 268);
            this.bDuePicker.Name = "bDuePicker";
            this.bDuePicker.Size = new System.Drawing.Size(62, 26);
            this.bDuePicker.TabIndex = 15;
            // 
            // vDuePicker
            // 
            this.vDuePicker.Location = new System.Drawing.Point(348, 301);
            this.vDuePicker.Name = "vDuePicker";
            this.vDuePicker.Size = new System.Drawing.Size(62, 26);
            this.vDuePicker.TabIndex = 16;
            // 
            // sDuePicker
            // 
            this.sDuePicker.Location = new System.Drawing.Point(348, 333);
            this.sDuePicker.Name = "sDuePicker";
            this.sDuePicker.Size = new System.Drawing.Size(62, 26);
            this.sDuePicker.TabIndex = 17;
            // 
            // hDuePicker
            // 
            this.hDuePicker.Location = new System.Drawing.Point(348, 365);
            this.hDuePicker.Name = "hDuePicker";
            this.hDuePicker.Size = new System.Drawing.Size(62, 26);
            this.hDuePicker.TabIndex = 18;
            // 
            // NytSkydekortPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 521);
            this.Controls.Add(this.hDuePicker);
            this.Controls.Add(this.sDuePicker);
            this.Controls.Add(this.vDuePicker);
            this.Controls.Add(this.bDuePicker);
            this.Controls.Add(this.serieHDuerLabel);
            this.Controls.Add(this.serieSDuerLabel);
            this.Controls.Add(this.serieVDuerLabel);
            this.Controls.Add(this.serieBDuerLabel);
            this.Controls.Add(this.seriesTypeLabel);
            this.Controls.Add(this.seriesSelecter);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateAsTitelCheckBox);
            this.Controls.Add(this.titelLabel);
            this.Controls.Add(this.titelTextBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.newCardHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NytSkydekortPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NytSkydekortPopup";
            ((System.ComponentModel.ISupportInitialize)(this.bDuePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDuePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDuePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDuePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newCardHeader;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox titelTextBox;
        private System.Windows.Forms.Label titelLabel;
        private System.Windows.Forms.CheckBox dateAsTitelCheckBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.ComboBox seriesSelecter;
        private System.Windows.Forms.Label seriesTypeLabel;
        private System.Windows.Forms.Label serieBDuerLabel;
        private System.Windows.Forms.Label serieVDuerLabel;
        private System.Windows.Forms.Label serieSDuerLabel;
        private System.Windows.Forms.Label serieHDuerLabel;
        private System.Windows.Forms.NumericUpDown bDuePicker;
        private System.Windows.Forms.NumericUpDown vDuePicker;
        private System.Windows.Forms.NumericUpDown sDuePicker;
        private System.Windows.Forms.NumericUpDown hDuePicker;
    }
}