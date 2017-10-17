using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cours_project_val_4
{
   public static class Program
    {
        public static List_Person list_person = new List_Person();
        public static Catalog catalog= new Catalog();
        public static Catalog requests = new Catalog();
        public static DateTime DateNow=new DateTime();
        public static int Count = 0;
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
            
        }
    }
}
