using AutoMapper;
using Core;
using Data.Entities;
using IService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.Infrastructure
{
    public class AutomapperRegister
    {
        public static void Configure()
        {
            Mapper.Initialize(
                cfg =>
                {
                    cfg.CreateMap<Item, ItemDTO>().PreserveReferences();
                    cfg.CreateMap<Data.Entities.Type, TypeDTO>()
                    .ForMember(
                        x => x.AmountOfDependencies,
                        y => y.MapFrom(z => z.Items.Count)
                    )
                    .PreserveReferences();
                }
            );
        }
    }
}
