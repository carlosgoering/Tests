namespace Tests.Servicos
{
    public class ServicoDeLog : IServicoDeLog
    {
        public void Log(string message) => Console.WriteLine(message);
    }
}
