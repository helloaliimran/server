﻿using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Bit.Core.Models.Api.Public
{
    public abstract class BaseAssociationWithPermissionsModel
    {
        /// <summary>
        /// The associated object's unique identifier.
        /// </summary>
        /// <example>bfbc8338-e329-4dc0-b0c9-317c2ebf1a09</example>
        [Required]
        public Guid? Id { get; set; }
        /// <summary>
        /// When true, the read only permission will not allow the user or group to make changes to items.
        /// </summary>
        [Required]
        public bool? ReadOnly { get; set; }
    }
}
