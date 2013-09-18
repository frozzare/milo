using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Milo.Spring.Interfaces
{
    public interface ILinq
    {
        IEnumerable<TEntity> Where<TEntity>(Func<TEntity, bool> predicate);
    }
}
