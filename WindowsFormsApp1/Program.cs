using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {

        static DialogResult GetDialogResult()
        {
            DialogResult result;
            string message = "Welcome to Windows Forms";
            //result=MessageBox.Show(message);
            string caption = "C# Programming";

            result=MessageBox.Show(message, caption, MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Question);

            return result;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //var result=GetDialogResult();
            //if (result == DialogResult.OK)
            //{
            //    MessageBox.Show("Okay Clicked");
            //}
            //else
            //{
            //    MessageBox.Show("Cancel Clicked");
            //}

            //if(result == DialogResult.Abort)
            //{
            //    MessageBox.Show("Abort");
            //}
            //else if (result == DialogResult.Ignore)
            //{
            //    MessageBox.Show("Ignore");
            //}
            //else if(result == DialogResult.Retry)
            //{
            //    MessageBox.Show("Retry");
            //}


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
