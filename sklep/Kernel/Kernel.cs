using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Repositories;
using Repositories.Imp;

namespace Sklep.Kernel
{
	public class Kernel : NinjectModule
	{
		public override void Load()
		{
			Bind<IKategoriaRepo>().To<KategoriaRepo>().InSingletonScope();
		}
	}
}
