namespace OpenELT.Interfaces
{
    public interface IOutputPlugin
    {
        bool TestConnection();
        IOutputConfiguration Configuration { get; set; }

    }
}
