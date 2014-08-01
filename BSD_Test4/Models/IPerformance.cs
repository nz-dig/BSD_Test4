using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrightstarDB.EntityFramework;

namespace BSD_Test4.Models
{
    [Entity]
    public interface IPerformance : IEvent
    {
        [PropertyType("ex:production")]
        IProduction Production { get; set; }
    }

    [Entity]
    public interface IPhoto
    {
        [PropertyType("ex:production")]
        IProduction Production { get; set; }
    }
}
