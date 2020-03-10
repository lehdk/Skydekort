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
    public partial class PersonDisplay : Form
    {
        private BindingSource skydekortBindingSource = new BindingSource();
        private Skydekort activeSkydekort;
        Image miss1Image;
        Image miss2Image;
        Image hit1Image;
        Image hit2Image;
        Image NotSetImage;

        List<Button> DueButtons;



        /// <summary>
        /// Constructor ti lat oprette formen
        /// </summary>
        /// <param name="person">Den person som skal indlæses i formen.</param>
        public PersonDisplay(Person person)
        {
            InitializeComponent();

            // init images
            miss1Image = Image.FromFile("res/miss1.png");
            miss2Image = Image.FromFile("res/miss2.png");
            hit1Image  = Image.FromFile("res/hit1.png");
            hit2Image  = Image.FromFile("res/hit2.png");
            NotSetImage= Image.FromFile("res/NotSet.png");


            DueButtons = new List<Button>();


            Program.application.activePerson = person;
            updateSkydekortListBox();

            personNameHeader.Text = person.ToString();
        }

        // Denne funktion kører når PersonDisplay formen lukkes
        // Den sørger for at at skydekortOpenPerson formen bliver synlig
        private void PersonDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.skydekortOpenPerson.Show();
        }

        // Når man skal lave et nyt skydekort
        private void createButton_Click(object sender, EventArgs e)
        {
            NytSkydekortPopup nspForm = new NytSkydekortPopup();
            nspForm.Show();
        }

        /// <summary>
        /// Til at opdatere listen med skydekort
        /// </summary>
        public void updateSkydekortListBox()
        {
            skydekortBindingSource.DataSource = Program.application.activePerson.Skydekort;
            skydekortListBox.DataSource = skydekortBindingSource;

            skydekortListBox.DisplayMember = "Display";
            skydekortListBox.ValueMember   = "Display";

            skydekortBindingSource.ResetBindings(false);

        }

        // Funktionen der kører når delete knappen trykkes
        private void deleteButton_Click(object sender, EventArgs e)
        {
            Program.application.activePerson.Skydekort.Remove((Skydekort)skydekortListBox.SelectedItem);
            Program.personDisplay.updateSkydekortListBox();
            Program.savePerson(Program.application.activePerson);
        }

        private void skydekortListBox_SelectedIndexChanged(object sender, EventArgs e) {    }

        // Skal vise skydekortet i panelet når der trykkes åben
        private void openButton_Click(object sender, EventArgs e)
        {
            activeSkydekort = (Skydekort) skydekortListBox.SelectedItem;
            Console.WriteLine("Loading skydekort: " + activeSkydekort.Display);
            reloadSkydekortPanel();
            Console.WriteLine(activeSkydekort.isInit);
        }

        public void reloadSkydekortPanel()
        {
            skydekortPanel.Controls.Clear();
            skydekortPanel.Controls.Add(bDueLabel);

            DueButtons.Clear();

            const int space = 50;

            Size btnSize = new Size(40, 40);

            const int xOffset = 15;
            const int yOffset = 50;

            // Bagduer
            int count = xOffset;
            for(int i = 0; i < activeSkydekort.targetAmounts[0]; i++)
            {
                Button button = new Button();
                button.Size = btnSize;

                button.Margin = new System.Windows.Forms.Padding(0);
                button.Location = new System.Drawing.Point(count, 40);
                button.UseVisualStyleBackColor = true;
                button.Name = "bDueButton" + i;
                button.MouseUp += buttonClickHandler;
                button.BackgroundImageLayout = ImageLayout.Zoom;

                DueButtons.Add(button);

                count += space;
            }

            //Venstreduer
            count = xOffset;
            for (int i = 0; i < activeSkydekort.targetAmounts[1]; i++)
            {
                Button button = new Button();
                button.Size = btnSize;

                button.Margin = new System.Windows.Forms.Padding(0);
                button.Location = new System.Drawing.Point(count, DueButtons[0].Location.Y + yOffset);
                button.UseVisualStyleBackColor = true;
                button.Name = "vDueButton" + i;
                button.MouseUp += buttonClickHandler;
                button.BackgroundImageLayout = ImageLayout.Zoom;

                DueButtons.Add(button);

                count += space;
            }

            //Spidsduer
            count = xOffset;
            for (int i = 0; i < activeSkydekort.targetAmounts[2]; i++)
            {
                Button button = new Button();
                button.Size = btnSize;

                button.Margin = new System.Windows.Forms.Padding(0);
                button.Location = new System.Drawing.Point(count, DueButtons[activeSkydekort.targetAmounts[0]].Location.Y + yOffset);
                button.UseVisualStyleBackColor = true;
                button.Name = "sDueButton" + i;
                button.MouseUp += buttonClickHandler;
                button.BackgroundImageLayout = ImageLayout.Zoom;

                DueButtons.Add(button);

                count += space;
            }

            //Højreduer
            count = xOffset;
            for (int i = 0; i < activeSkydekort.targetAmounts[3]; i++)
            {
                Button button = new Button();
                button.Size = btnSize;

                button.Margin = new System.Windows.Forms.Padding(0);
                button.Location = new System.Drawing.Point(count, DueButtons[activeSkydekort.targetAmounts[0] + activeSkydekort.targetAmounts[1]].Location.Y + yOffset);
                button.UseVisualStyleBackColor = true;
                button.Name = "hDueButton" + i;
                button.MouseUp += buttonClickHandler;
                button.BackgroundImageLayout = ImageLayout.Zoom;

                DueButtons.Add(button);

                count += space;
            }

            for(int i = 0; i < DueButtons.Count; i++)
            {
                DueButtons[i].BackgroundImage = dueDataToImg(activeSkydekort.duer[i]);
                skydekortPanel.Controls.Add(DueButtons[i]);
            }
        }

        private Image dueDataToImg(int id)
        {
            Console.WriteLine(id);
            switch (id) {
                case 0:
                    return miss1Image;
                case 1:
                    return miss2Image;
                case 2:
                    return hit1Image;
                case 3:
                    return hit2Image;
                default:
                    return NotSetImage;
            }
        }

        public void buttonClickHandler(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            int btnIndex = int.Parse(button.Name.Substring(10));

            if(button.Name.StartsWith("vDueButton")) btnIndex += activeSkydekort.targetAmounts[0];
            else if(button.Name.StartsWith("sDueButton")) btnIndex += activeSkydekort.targetAmounts[0] + activeSkydekort.targetAmounts[1];
            else if (button.Name.StartsWith("hDueButton")) btnIndex += activeSkydekort.targetAmounts[0] + activeSkydekort.targetAmounts[1] + activeSkydekort.targetAmounts[2];
            
            if(e.Button == MouseButtons.Left)
            {
                if(activeSkydekort.duer[btnIndex] == 9 || activeSkydekort.duer[btnIndex] == 3 || activeSkydekort.duer[btnIndex] == 0 || activeSkydekort.duer[btnIndex] == 1)
                {
                    activeSkydekort.duer[btnIndex] = 2;
                    DueButtons[btnIndex].BackgroundImage = hit1Image;
                }
                else if(activeSkydekort.duer[btnIndex] == 2)
                {
                    activeSkydekort.duer[btnIndex] = 3;
                    DueButtons[btnIndex].BackgroundImage = hit2Image;
                }

            }

            else if(e.Button == MouseButtons.Right)
            {
                if (activeSkydekort.duer[btnIndex] == 9 || activeSkydekort.duer[btnIndex] == 1 || activeSkydekort.duer[btnIndex] == 2 || activeSkydekort.duer[btnIndex] == 3)
                {
                    activeSkydekort.duer[btnIndex] = 0;
                    DueButtons[btnIndex].BackgroundImage = miss1Image;
                }
                else if (activeSkydekort.duer[btnIndex] == 0)
                {
                    activeSkydekort.duer[btnIndex] = 1;
                    DueButtons[btnIndex].BackgroundImage = miss2Image;
                }
            }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Program.application.activePerson.Skydekort[skydekortListBox.SelectedIndex] = activeSkydekort;
            Program.savePerson(Program.application.activePerson);
        }
    }
}
