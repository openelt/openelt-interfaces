using System.Collections;
using System.Collections.Generic;
using OpenELT.Interfaces.Models;

namespace OpenELT.Interfaces
{
    public interface IInputPlugin
    {
        bool TestConnection();
        IInputConfiguration Configuration { get; set; }

        IEnumerable<Data> Read();

    }
}
