using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LectorQRv2.Views;

namespace LectorQRv2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Creación y Acceso de base de datos `Parqueo`
            string DBConnectionString = Properties.Settings.Default.NormanConnection; // hay que cambiar el string de conexion 
            Models.ParqueoDataModelDataContext db = new Models.ParqueoDataModelDataContext(DBConnectionString);
            if (!db.DatabaseExists())
            {
                try
                {
                    db.CreateDatabase();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al acceder a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //se cierra la aplicación
                }
            }
            #endregion 
            // si llega a esta parte, hay garantia de que estoy conectado a Base de datos

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());// se abre la ventana principal de la aplicacion.
        }
    }
}
