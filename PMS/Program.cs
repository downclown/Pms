using PMS.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
           // Application.Run(new AdminDashboard());
            //Application.Run(new PharmacistDashboard());
             //Application.Run(new CashierDashboard());
             //Application.Run(new InventoryManagerDashboard());
             //Application.Run(new StockManagement());
             Application.Run(new StockValidity());
        }
    }
}
