using System;
using System.Collections.Generic;
using System.Text;

namespace ADO.NET.Helpers.Generics
{
    // we can create a common generic interface which we will use in any new interface to avoid adding same logic every time
    public interface GenericInterface<T>
    {
        List<T> GetAll();

        T InsertUpdate(T item);
        T GetById(int id);
        // more common methods.
    }
}
