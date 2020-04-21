using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Domain.Entities.Base
{
    public abstract class BaseEntity 
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
