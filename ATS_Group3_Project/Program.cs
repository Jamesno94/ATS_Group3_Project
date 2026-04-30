using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace ATS_Group3_Project
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new ATSDbInitializer());

            using (var db = new ATSContext())
            {
                db.Database.Initialize(false);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin()); // James - need to connect this to login form and then set to main via project properties 
        }
    }
}
