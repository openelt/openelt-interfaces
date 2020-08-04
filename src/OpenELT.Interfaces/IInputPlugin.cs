namespace OpenELT.Interfaces
{
    public interface IInputPlugin
    {
        bool TestConnection();
        IInputConfiguration Configuration { get; set; }

    }
}
