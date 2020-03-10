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
using LehSerializer;

namespace SkydekortGUI
{
    public partial class OpretPerson : Form
    {
        private bool uidOK = false, firstOK = false, lastOK = false;

        public OpretPerson()
        {
            InitializeComponent();
            createButton.Enabled = false;
        }

        private void OpretPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.skydekortOpenPerson.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {

            Person p = new Person();
            p.FirstName = firstNameTextbox.Text;
            p.Lastname = lastNameTextbox.Text;
            p.uID = UInt32.Parse(UIDTextbox.Text);

            Program.savePerson(p);

            Program.skydekortOpenPerson.updatePersonListBox();

            this.Close();
        }

        // Når der bliver skrevet i tekstboks til UID
        private void UIDTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sørger for at der kun kan skrives tal i tekstboksen
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        // Når teksten UID bliver ændret
        private void Textbox_TextChanged(object sender, EventArgs e)
        {


            if(((TextBox)sender).Name == UIDTextbox.Name)
            {
                bool isUIDValid = false;

                if(UIDTextbox.Text != "") isUIDValid = !Program.application.usedUIDS.Contains(UInt32.Parse(UIDTextbox.Text));

                if (UIDTextbox.Text.Length > 3 && isUIDValid) uidOK = true; else uidOK = false;
            }

            if (((TextBox)sender).Name == firstNameTextbox.Name)
            {
                if (firstNameTextbox.TextLength > 1) firstOK = true; else firstOK = false;
            }

            if (((TextBox)sender).Name == lastNameTextbox.Name)
            {
                if (lastNameTextbox.TextLength > 1) lastOK = true; else lastOK = false;
            }

            if (firstOK && lastOK && uidOK) createButton.Enabled = true; else createButton.Enabled = false;
        }
    }
}
