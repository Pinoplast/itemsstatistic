using Autofac;
using Data;
using Data.Interfaces;
using Data.Repositories;
using IService.Interfaces;
using IService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.Infrastructure
{
    public class DataModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DatabaseContext>().As<DatabaseContext>().InstancePerRequest();

            builder.RegisterType<TypesService>().As<ITypesService>().InstancePerRequest();
            builder.RegisterType<ItemsService>().As<IItemsService>().InstancePerRequest();

            builder.RegisterType<TypesRepository>().As<ITypesRepository>().InstancePerRequest();
            builder.RegisterType<ItemsRepository>().As<IItemsRepository>().InstancePerRequest();
        }
    }
}
