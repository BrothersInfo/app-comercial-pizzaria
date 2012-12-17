using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pizzaria
{
    using Pizzaria.Banco;
    using Pizzaria.Properties;
    using Pizzaria.Classes;
    using Pizzaria.Tela;
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                
            //    Fundo f = new Fundo();
             //   f.ShowDialog();
              //  f.ShowIcon = true;


                 Application.Run(new Fundo()                    );
           }            catch { return; }
            
        }
    }
}
