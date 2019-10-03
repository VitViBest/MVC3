using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskMVC1.DAL.Interfaces;
using TaskMVC1.DAL.Services;

namespace TaskMVC1.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument("connectionString", "DefaultConnection");
        }
    }
}