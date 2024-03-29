﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrightstarDB.EntityFramework;

namespace BSD_Test4.Models
{
    [Entity("http://xmlns.com/foaf/0.1/Person")]
    public interface IPerson
    {
        /// <summary>
        /// Get the persistent identifier for this entity
        /// </summary>
        [Identifier("ex:people#")]
        string Id { get; }

        [PropertyType("foaf:title")]
        string Title { get; set; }
        
        [PropertyType("foaf:nick")]
        string Nickname { get; set; }

        [PropertyType("foaf:givenName")]
        string FirstName { get; set; }

        [PropertyType("foaf:familyName")]
        string LastName { get; set; }
    }
}
