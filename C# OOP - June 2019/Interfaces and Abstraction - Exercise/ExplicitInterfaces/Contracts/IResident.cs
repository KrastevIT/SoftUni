using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces.Contracts
{
    public interface IResident
    {
        string name { get; }

        string country { get; }

        string GetName();
    }
}
