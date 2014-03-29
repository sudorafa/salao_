using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto4_Junior
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Autenticacao aut = new Autenticacao();
            Application.Run(new Form_Index());     
            if (aut.ShowDialog() == DialogResult.OK)
            {            
                //Application.Run(new Form_Index());                
            }            
        }
    }
}
