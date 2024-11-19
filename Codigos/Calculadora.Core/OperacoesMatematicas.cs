namespace Calculadora_V0.Core
{
    /*
     * A classe OperacoesMatematicas é responsável por instanciar a operação matemática correspondente.
     * Implementa o padrão de projeto Strategy.
     */

    public interface IOperacaoMatematica
    {
        float Operacao(float a, float b);
    }

    public class Adicao : IOperacaoMatematica
    {
        public float Operacao(float a, float b)
        {
            return a += b;
        }
    }
    
    public class Subtracao : IOperacaoMatematica
    {
        public float Operacao(float a, float b)
        {
            return a -= b;
        }
    }

    public class Multiplicacao : IOperacaoMatematica
    {
        public float Operacao(float a, float b)
        {
            return a *= b;
        }
    }

    public class Divisao : IOperacaoMatematica
    {
        public float Operacao(float a, float b)
        {
            if (b == 0)
                throw new DivideByZeroException("Não é possível dividir por zero.");
            return a /= b;
        }
    }

    public class Modulo : IOperacaoMatematica
    {
        public float Operacao(float a, float b)
        {
            return a %= b;
        }
    }

    // A classe correspondente ao Context do padrão Strategy.
    public class OperacoesMatematicas
    {
        private IOperacaoMatematica _operacaoMatematica;

        public OperacoesMatematicas(IOperacaoMatematica operacaoMatematica)
        {
            _operacaoMatematica = operacaoMatematica;
        }

        public float RealizarOperacao(float a, float b)
        {
            return _operacaoMatematica.Operacao(a, b);
        }
    }
}
