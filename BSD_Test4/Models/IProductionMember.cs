using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrightstarDB.EntityFramework;

namespace BSD_Test4.Models
{
    [Entity]
    public interface IProductionMember
    {
        /// <summary>
        /// Get the persistent identifier for this entity
        /// </summary>
        string Id { get; }

        [PropertyType("ex:person")]
        IPerson Person { get; set; }

        [PropertyType("ex:role")]
        IRole Role { get; set; }

        [PropertyType("ex:production")]
        IProduction Production { get; set; }

      
    }
}
