using Tests.Servicos;

namespace Tests
{
    public class Calculadora
    {
        IServicoDeLog _servicoDeLog;
        public Calculadora(IServicoDeLog servicoDeLog)
        {
            _servicoDeLog = servicoDeLog;
        }

        public int Soma(int a, int b)
        {
            var resultado = a + b;
            _servicoDeLog.Log($"A soma é {resultado}");

            return resultado;
        }
    }
}
