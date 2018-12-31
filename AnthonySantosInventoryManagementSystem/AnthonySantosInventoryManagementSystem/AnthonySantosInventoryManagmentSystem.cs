using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnthonySantosInventoryManagementSystem
{
    static class AnthonySantosInventoryManagmentSystem
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Inventory.MyPartList.Add(new Inhouse(987, "guitar body", 100, 9, 1, 10, 88));
            Inventory.MyPartList.Add(new Inhouse(876, "guitar neck", 50, 7, 1, 10, 76));
            Inventory.MyPartList.Add(new Outsourced(234, "tuning pegs", 2, 20, 6, 100, "Grover"));
            Inventory.MyPartList.Add(new Outsourced(456, "guitar strings", 15, 48, 6, 100, "Elixir"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InventoryManagementSystemMainScreen());

        }
    }
}
