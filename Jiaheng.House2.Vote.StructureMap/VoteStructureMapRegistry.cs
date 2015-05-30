
using Jiaheng.House2.Vote.Repository.Dao;
using Jiaheng.House2.Vote.Repository.Interfaces;
using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiaheng.House2.Vote.StructureMap
{
    public class VoteStructureMapRegistry : Registry
    {
        public VoteStructureMapRegistry()
        {
            SelectConstructor(() => new Entityframework.Entities());
            For(typeof(IIPTableRepository<>)).Use(typeof(IPTablesRepository));
        }
    }
}
