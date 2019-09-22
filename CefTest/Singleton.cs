
namespace CefTest
{
	using System.Threading;

	public sealed class Singleton
	{
		//Wind data fields
		public float? _waSpd = null;
		public float? _waSpd5 = null;

		private Singleton()
		{
		}

		public Singleton ShallowCopy()
		{
			//Singleton sgl;
			lock (_lock)
			{
				//sgl = (Singleton)this.MemberwiseClone();
				//Thread.Sleep(10000);
				return (Singleton)this.MemberwiseClone();
				//Thread.Sleep(10000);
			}
			//return sgl;
		}

		private static readonly object _lock = new object();

		private static readonly Singleton _instance = new Singleton();
		public static Singleton Instance
		{
			get
			{
				return _instance;
			}
		}

		public void LockMe()
		{
			Monitor.Enter(this);
		}

		public void UnLockMe()
		{
			Monitor.Exit(this);
		}

	}
}
