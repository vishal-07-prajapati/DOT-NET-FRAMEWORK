using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADO.NET.Helpers
{
    public static class CommonExtenstions
    {
        public static bool AnyItems<T>(this List<T> list) => list != null && list.Any();
    }
}