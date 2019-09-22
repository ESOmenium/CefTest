using System;
using System.Windows.Forms;

namespace CefTest {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Form1 f1 = new Form1();
			Application.Run(f1);
			f1.Close();
			Application.Exit();
		}
	}
}
