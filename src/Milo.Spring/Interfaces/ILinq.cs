using System;
using System.Collections.Generic;

namespace Milo.Spring.Interfaces
{
    public interface ILinq
    {
        IEnumerable<T> Query<T>();
    }
}
