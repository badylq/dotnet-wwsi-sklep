using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading;
using Models;

namespace Sklep.Kernel
{
	public sealed class Cache
	{
		private static volatile Cache instance;
		private static object syncRoot = new Object();

		private Cache() { }
		public ConcurrentDictionary<string, Cart> Carts { get; set; }
		public static Cache Instance
		{
			get
			{
				if (instance == null)
				{
					lock (syncRoot)
					{
						if (instance == null)
						{
							instance = new Cache();
							new Thread(() =>
							{
								Thread.CurrentThread.IsBackground = true;
								Thread.CurrentThread.Name = "Cache";
								while (true)
								{
									instance.Carts.Clear();
									Thread.Sleep(30 * 60000);
								}
							}).Start();
						}
					}
				}
				return instance;
			}
		}
	}
}
