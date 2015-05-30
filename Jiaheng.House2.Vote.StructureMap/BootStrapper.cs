using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiaheng.House2.Vote.StructureMap
{
    public class BootStrapper
    {
        public static void ConfigureStructureMap()
        {
            ObjectFactory.Configure(x =>
            {
                x.AddRegistry(new VoteStructureMapRegistry());

                x.Scan(scanner =>
                {
                    scanner.Assembly("Jiaheng.House2.Vote.Repository");
                    scanner.Assembly("Jiaheng.House2.Vote.Services");
                });
            });
        }
    }
}
