using System.Collections.Generic;
using OpenELT.Interfaces.Models;

namespace OpenELT.Interfaces
{
    public interface IOutputPlugin
    {
        bool TestConnection();
        IOutputConfiguration Configuration { get; set; }
        bool Write(IEnumerable<Data> data);

    }
}
