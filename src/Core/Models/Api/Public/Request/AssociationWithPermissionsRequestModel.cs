﻿using Bit.Core.Models.Data;

namespace Bit.Core.Models.Api.Public
{
    public class AssociationWithPermissionsRequestModel : BaseAssociationWithPermissionsModel
    {
        public SelectionReadOnly ToSelectionReadOnly()
        {
            return new SelectionReadOnly
            {
                Id = Id.Value,
                ReadOnly = ReadOnly.Value
            };
        }
    }
}
