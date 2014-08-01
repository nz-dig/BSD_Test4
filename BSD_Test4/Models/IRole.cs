using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrightstarDB.EntityFramework;

namespace BSD_Test4.Models
{
    [Entity]
    public interface IRole
    {
        /// <summary>
        /// Get the persistent identifier for this entity
        /// </summary>
        [Identifier("ex:roles#")]
        string Id { get; }
        
        [PropertyType("ex:rolename")]
        string Name { get; set; }
        
        [PropertyType("ex:roletype")]
        string RoleType { get; set; }
    }
}
