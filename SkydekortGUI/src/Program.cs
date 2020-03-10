using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using SkydekortLibrary;
using LehSerializer;
using System.Drawing;

namespace SkydekortGUI
{
    static class Program
    {

        //Sti til der hvor user filerne skal gemmes
        public const string pathToPeople = "people/";

        // Objekt til at holde styr på ting i programmet
        public static  ApplicationClass application = new ApplicationClass();

        // Til ikonet i hjørnet
        private static NotifyIcon cornerIcon;

        // Andre forms
        public static SkydekortOpenPerson skydekortOpenPerson;
        public static PersonDisplay personDisplay;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main()
        {
            // People folder creation
            createPeopleFolderIfNotExist();

            // Enable GUI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Cornericon
            cornerIcon = new NotifyIcon();
            cornerIcon.Icon = new Icon("res/menuIcon.ico");
            cornerIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            cornerIcon.ContextMenuStrip.Items.Add("About", null, cornerMenuAboutClick);
            cornerIcon.ContextMenuStrip.Items.Add("Exit", null, cornerMenuExitClick);
            cornerIcon.Visible = true;
            
            // Display
            skydekortOpenPerson = new SkydekortOpenPerson();
            Application.Run(skydekortOpenPerson);

            // DENNE KODE KØRER NÅR PROGRAMMET LUKKES
            Console.WriteLine("Application closing...");
            Program.skydekortOpenPerson.Hide();
            cornerIcon.Visible = false;
            cornerIcon.Dispose();

            return 0;
        }

        // Når man i cornermenu trykker på exit
        private static void cornerMenuExitClick(object sender, EventArgs e)
        {
            skydekortOpenPerson.Dispose();
        }

        // Når man i cornermenu trykker på about
        private static void cornerMenuAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("Denne applikation er lavet af Lehdk\nCopyright \u00a9 2020", "About");
        }

        /// <summary>
        /// Opretter mappen til at gemme user filer hvis den ikke eksisterer.
        /// </summary>
        private static void createPeopleFolderIfNotExist()
        {

            if(System.IO.Directory.Exists(pathToPeople))
            {
                Console.WriteLine(pathToPeople + " directory has been detected.");
            } else
            {
                Console.Error.WriteLine(pathToPeople + " directory has not been detected.");
                Console.WriteLine("Creating directory " + pathToPeople);
                System.IO.Directory.CreateDirectory(pathToPeople);
            }
        }

        /// <summary>
        /// Denne funktion gennemsøger mappen med person filer og loader dem ind i programmet
        /// </summary>
        public static void reloadPeopleList()
        {
            application.people.Clear();
            application.usedUIDS.Clear();

            string[] filesInDir = System.IO.Directory.GetFiles(Program.pathToPeople);
            for (int i = 0; i < filesInDir.Length; i++)
            {
                if (filesInDir[i].EndsWith(".usr"))
                {
                    application.addToPeopleList((Person)LehLoader.ReadXML(filesInDir[i], typeof(Person)));
                }
            }
        }

        /// <summary>
        /// Til at gemme personer som XML fil
        /// </summary>
        /// <param name="person">Person objektet som skal gemmes</param>
        public static void savePerson(Person person)
        {
            LehSaver.WriteToXML(person, Program.pathToPeople + person.uID + ".usr", typeof(Person));
        }
    }
}
