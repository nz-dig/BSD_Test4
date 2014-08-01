using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrightstarDB.EntityFramework;

namespace BSD_Test4.Models
{
    [Entity]
    public interface IProduction
    {
        /// <summary>
        /// Get the persistent identifier for this entity
        /// </summary>
        [Identifier("ex:productions#")]
        string Id { get; }

        [PropertyType("ex:productiontitle")]
        string Title { get; set; }

        [InverseProperty("Production")]
        ICollection<IPerformance> Performances { get; set; }

        [InverseProperty("Production")]
        ICollection<IProductionMember> ProductionTeam { get; set; }

        [InverseProperty("Production")]
        ICollection<IPhoto> Photos { get; set; }
 
    
    }
}
