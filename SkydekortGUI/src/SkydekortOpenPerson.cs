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
    public partial class SkydekortOpenPerson : Form
    {
        public SkydekortOpenPerson()
        {
            InitializeComponent();
            updatePersonListBox();
            openPerson.Enabled = false;
        }

        BindingSource personBindingSource = new BindingSource();        

        private void openPerson_Click(object sender, EventArgs e)
        {
            Program.personDisplay = new PersonDisplay((Person)personListBox.SelectedItem);
            Program.personDisplay.Show();

            this.Hide();
        }

        public void updatePersonListBox()
        {
            Program.reloadPeopleList();

            personBindingSource.DataSource = Program.application.people;
            personListBox.DataSource = personBindingSource;

            personListBox.DisplayMember = "Display";
            personListBox.ValueMember   = "Display";

            personBindingSource.ResetBindings(false);
        }

        private void deletePerson_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(Program.pathToPeople + ((Person)personListBox.SelectedItem).uID + ".usr");

            updatePersonListBox();
        }

        private void createPerson_Click(object sender, EventArgs e)
        {
            OpretPerson opretPersonForm = new OpretPerson();
            opretPersonForm.Show();
            Program.skydekortOpenPerson.Hide();
        }

        private void personListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personListBox.SelectedItem != null) openPerson.Enabled = true;
        }
    }
}
