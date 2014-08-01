using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrightstarDB.EntityFramework;

namespace BSD_Test4.Models
{
    [Entity]
    public interface IEvent
    {
        /// <summary>
        /// Get the persistent identifier for this entity
        /// </summary>
        string Id { get; }

        [PropertyType("ex:datetime")]
        DateTime DateTime { get; set; }
    }
}
