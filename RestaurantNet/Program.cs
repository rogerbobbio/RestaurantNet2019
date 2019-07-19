using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantNet
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
      frmLogin loginForm = new frmLogin();
      DialogResult result = loginForm.ShowDialog();
      if (result == DialogResult.OK)
        Application.Run(new frmMainMenu());
    }
  }
}
