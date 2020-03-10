using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SkydekortLibrary;

namespace SkydekortGUI
{
    public partial class NytSkydekortPopup : Form
    {
        public NytSkydekortPopup()
        {
            InitializeComponent();
            dateTimePicker.Value = DateTime.Now;
            seriesSelecter.SelectedItem = "24 serie";
        }

        // Når opret knappen trykkes
        private void createButton_Click(object sender, EventArgs e)
        {
            Skydekort s = new Skydekort((int)bDuePicker.Value, (int)vDuePicker.Value, (int)sDuePicker.Value, (int)hDuePicker.Value);
            s.titel = titelTextBox.Text;
            s.Description = DescriptionTextBox.Text;
            s.date = dateTimePicker.Value;
            s.ownerUID = Program.application.activePerson.uID;

            Program.application.activePerson.Skydekort.Add(s);

            Program.savePerson(Program.application.activePerson);

            Program.personDisplay.updateSkydekortListBox();

            this.Dispose();
        }

        private void dateAsTitelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(dateAsTitelCheckBox.Checked)
            {
                titelTextBox.Enabled = false;
                titelTextBox.Text = dateTimePicker.Value.Date.ToString("dd/MM/yyyy");
            } else
            {
                titelTextBox.Enabled = true;
            }
        }

        // Når serievælgeren ændres
        private void seriesSelecter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(seriesSelecter.Text == "24 serie")
            {
                bDuePicker.Enabled = false;
                vDuePicker.Enabled = false;
                sDuePicker.Enabled = false;
                hDuePicker.Enabled = false;

                bDuePicker.Value = 6;
                vDuePicker.Value = 6;
                sDuePicker.Value = 6;
                hDuePicker.Value = 6;
            } 
            else if (seriesSelecter.Text == "32 serie")
            {
                bDuePicker.Enabled = false;
                vDuePicker.Enabled = false;
                sDuePicker.Enabled = false;
                hDuePicker.Enabled = false;

                bDuePicker.Value = 8;
                vDuePicker.Value = 8;
                sDuePicker.Value = 8;
                hDuePicker.Value = 8;
            }
            else if (seriesSelecter.Text == "40 serie")
            {
                bDuePicker.Enabled = false;
                vDuePicker.Enabled = false;
                sDuePicker.Enabled = false;
                hDuePicker.Enabled = false;

                bDuePicker.Value = 10;
                vDuePicker.Value = 10;
                sDuePicker.Value = 10;
                hDuePicker.Value = 10;
            }
            else if (seriesSelecter.Text == "speciel")
            {
                bDuePicker.Enabled = true;
                vDuePicker.Enabled = true;
                sDuePicker.Enabled = true;
                hDuePicker.Enabled = true;

                bDuePicker.Value = 6;
                vDuePicker.Value = 6;
                sDuePicker.Value = 6;
                hDuePicker.Value = 6;
            }
        }

    }
}
