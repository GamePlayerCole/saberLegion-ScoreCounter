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
            //Contestant 1 Files
            if(File.Exists("contestant1.txt"))
            {
                //Do Nothing
            }
            else
            {
                File.Create("contestant1.txt");
            }
            if (File.Exists("contestant1Score.txt"))
            {
                //Do Nothing
            }
            else
            {
                File.Create("contestant1Score.txt");
            }

            //Contestant 2 Files
            if (File.Exists("contestant2.txt"))
            {
                //Do Nothing
            }
            else
            {
                File.Create("contestant2.txt");
            }
            if (File.Exists("contestant2Score.txt"))
            {
                //Do Nothing
            }
            else
            {
                File.Create("contestant2Score.txt");
            }
        }
    }
}
