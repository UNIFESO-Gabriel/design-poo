namespace Calculadora_V0.Core
{
    /// <summary>
    /// Fábrica responsável por descobrir e criar instâncias de operações matemáticas
    /// usando reflexão para encontrar todas as classes que implementam IOperacaoMatematica
    /// </summary>
    public class Fabrica
    {
        // Dicionário que guarda o mapeamento entre:
        // - Chave: nome do RadioButton (ex: "radioAdicao")
        // - Valor: tipo da classe de operação (ex: typeof(Adicao))
        private readonly Dictionary<string, Type> dictOperacoes;

        public Fabrica()
        {
            // Inicializa o dicionário usando reflexão para descobrir as operações
            dictOperacoes = AppDomain.CurrentDomain.GetAssemblies() // Pega todas as DLLs carregadas
                .SelectMany(assembly => assembly.GetTypes())     // De cada DLL, pega todas as classes
                .Where(type =>                                   // Filtra as classes para pegar somente:
                    // 1. Classes que implementam nossa interface IOperacaoMatematica;
                    // 2. Não pode ser interface (precisa ser classe concreta)
                    // 3. Não pode ser classe abstrata (precisa poder instanciar)
                    typeof(IOperacaoMatematica).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract)
                // Converte para dicionário onde:
                // Para a chave: pega o nome da classe e adiciona "radio" na frente
                // Exemplo: classe Adicao vira "radioAdicao"

                // Para o valor: guarda o tipo (Type) da própria classe
                // Será usado depois para criar instâncias.
                .ToDictionary(                                      
                    type => "radio" + type.Name,                    
                    type => type
                );
        }

        /// <summary>
        /// Cria uma instância da operação matemática baseado no nome do RadioButton
        /// </summary>
        /// <param name="nomeRadio">Nome do RadioButton (ex: "radioAdicao")</param>
        /// <returns>Nova instância da operação matemática</returns>
        public IOperacaoMatematica CriarInstancia(string nomeRadio)
        {
            // Tenta encontrar o tipo da operação no dicionário. Se não encontrar, lança exceção.
            if (!dictOperacoes.TryGetValue(nomeRadio, out Type tipo))
                throw new InvalidOperationException($"Operação {nomeRadio.Substring(5)} não encontrada");

            // Cria uma nova instância do tipo encontrado
            // Convertendo para nossa interface IOperacaoMatematica
            return (IOperacaoMatematica)Activator.CreateInstance(tipo);
        }
    }
}
