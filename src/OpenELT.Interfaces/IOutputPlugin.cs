using System.Collections.Generic;
using OpenELT.Interfaces.Models;

namespace OpenELT.Interfaces
{
    public interface IOutputPlugin
    {
        bool TestConnection();
        IOutputConfiguration Configuration { get; set; }
        bool Send(IEnumerable<Data> Write);

    }
}
