using System;
using System.Windows.Forms;

using CefSharp;
using CefSharp.WinForms;

namespace CefTest
{
	using System.Diagnostics;
	using System.Threading;

	public partial class Form1 : Form
	{
		private string m_windsUrl = "http://localhost/OmnPortal/Observers/Winds/7fc30138-9d5c-e511-80cc-008cfa5abd0b/en";
		private string m_enviroUrl = "http://localhost/OmnPortal/Observers/Environments/7fc30138-9d5c-e511-80cc-008cfa5abd0b/en";
		private string m_precipUrl = "http://localhost/OmnPortal/Observers/Precipitations/7fc30138-9d5c-e511-80cc-008cfa5abd0b/en";

		private string m_version = "chrome://version";

		//private static Singleton _singleton = new Singleton();

		private Singleton _singleton2 = null;

		public Form1()
		{
			InitializeComponent();

			this.SingletonAsObject();

			SingletonExplicit();

			//this.Close();
			Application.Exit();
			//InitBrowser();
		}

		public void SingletonExplicit()
		{
			Debug.WriteLine("SingletonExplicit =============");

			Thread t1 = new Thread( () => {
				//Monitor.Enter(Singleton.Instance);
				//Singleton.Instance.LockMe();

				lock (Singleton.Instance)
				{
					Singleton.Instance._waSpd = 1.1F;
					Debug.WriteLine("t1.1: _singleton waSpd=" + Singleton.Instance._waSpd);
					//Thread.Sleep(200);
					float j = 0.0f;
					for (int i = 0; i < 100000; i++)
					{
						j += i * 2;
					}
					Debug.WriteLine("t1.2: _singleton waSpd=" + Singleton.Instance._waSpd);

					Singleton.Instance._waSpd = 3.3F;
					Debug.WriteLine("t1.3: _singleton waSpd=" + Singleton.Instance._waSpd);
				}
				//Monitor.Exit(Singleton.Instance);
				//Singleton.Instance.UnLockMe();
			});
			t1.IsBackground = true;
			t1.Start();

			Debug.WriteLine("t0.1: _singleton waSpd=" + Singleton.Instance._waSpd);

			Singleton.Instance._waSpd = 4.4F;

			Debug.WriteLine("t0.2: _singleton waSpd=" + Singleton.Instance._waSpd);

			this._singleton2 = Singleton.Instance.ShallowCopy();

			Singleton.Instance._waSpd = 5.5F;

			Debug.WriteLine("t0.3: _singleton waSpd=" + Singleton.Instance._waSpd);
			Debug.WriteLine("t0.4: _singleton2 waSpd=" + this._singleton2._waSpd);

			this._singleton2 = Singleton.Instance.ShallowCopy();
			Debug.WriteLine("t0.5: _singleton waSpd=" + Singleton.Instance._waSpd);
			Debug.WriteLine("t0.6: _singleton2 waSpd=" + this._singleton2._waSpd);

			Thread.Sleep(1000);
			Singleton.Instance._waSpd = 9.9F;
			Debug.WriteLine("t0.7: _singleton waSpd=" + Singleton.Instance._waSpd);
			Debug.WriteLine("t0.8: _singleton2 waSpd=" + this._singleton2._waSpd);		
		}

		public void SingletonAsObject()
		{
			Debug.WriteLine("SingletonAsObject =============");

			Singleton _sgl = Singleton.Instance;
			Thread t1 = new Thread(() =>
			{
				//Monitor.Enter(Singleton.Instance);
				//Singleton.Instance.LockMe();

				lock (_sgl)
				{
					_sgl._waSpd = 1.1F;
					Debug.WriteLine("t1.1: _singleton waSpd=" + _sgl._waSpd);
					//Thread.Sleep(200);
					float j = 0.0f;
					for (int i = 0; i < 100000; i++)
					{
						j += i * 2;
					}
					Debug.WriteLine("t1.2: _singleton waSpd=" + _sgl._waSpd);

					_sgl._waSpd = 3.3F;
					Debug.WriteLine("t1.3: _singleton waSpd=" + _sgl._waSpd);
				}
				//Monitor.Exit(_sgl);
				//_sgl.UnLockMe();
			});
			t1.IsBackground = true;
			t1.Start();

			Debug.WriteLine("t0.1: _singleton waSpd=" + _sgl._waSpd);

			_sgl._waSpd = 4.4F;

			Debug.WriteLine("t0.2: _singleton waSpd=" + _sgl._waSpd);

			this._singleton2 = _sgl.ShallowCopy();

			_sgl._waSpd = 5.5F;

			Debug.WriteLine("t0.3: _singleton waSpd=" + _sgl._waSpd);
			Debug.WriteLine("t0.4: _singleton2 waSpd=" + this._singleton2._waSpd);

			this._singleton2 = _sgl.ShallowCopy();
			Debug.WriteLine("t0.5: _singleton waSpd=" + _sgl._waSpd);
			Debug.WriteLine("t0.6: _singleton2 waSpd=" + this._singleton2._waSpd);

			Thread.Sleep(1000);
			_sgl._waSpd = 9.9F;
			Debug.WriteLine("t0.7: _singleton waSpd=" + _sgl._waSpd);
			Debug.WriteLine("t0.8: _singleton2 waSpd=" + this._singleton2._waSpd);

		}


		public ChromiumWebBrowser browser;
		public void InitBrowser()
		{
			CefSettings cefSettings = new CefSettings();
			CefSharpSettings.WcfEnabled = false;

			Cef.Initialize(cefSettings);
			browser = new ChromiumWebBrowser(m_windsUrl);
			this.panel1.Controls.Add(browser);
			browser.Dock = DockStyle.Fill;
		}

		private void btnVersion_Click(object sender, EventArgs e)
		{
			this.browser.Load(this.m_version);
		}

		private void btnWinds_Click(object sender, EventArgs e)
		{
			this.browser.Load(this.m_windsUrl);
		}

		private void btnEnviro_Click(object sender, EventArgs e)
		{
			this.browser.Load(this.m_enviroUrl);
		}



	}
}
