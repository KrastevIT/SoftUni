using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces.Contracts
{
    public interface IPerson
    {
        string name { get; }

        int age { get; }

        string GetName();
    }
}
