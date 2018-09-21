using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace scoreCounter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Checks if required text files exist. If not, it creates them.
            CheckRequiredFiles();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        static void CheckRequiredFiles()
        {
            //Creates seperate files for each one since OBS can not parse file data into seperate sources.
            File.WriteAllText("contestant1.txt", String.Empty);
            File.WriteAllText("contestant1Score.txt", "0");
            File.WriteAllText("contestant2.txt", String.Empty);
            File.WriteAllText("contestant2Score.txt", "0");
            File.WriteAllText("roundNumber.txt", "1");
        }
    }
}
