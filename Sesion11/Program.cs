namespace Reto;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        using (var db = new AgendaContext())
            db.Database.EnsureCreated();

        Application.Run(new Form1());
    }
}
