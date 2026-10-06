namespace StreamingFlix.App;

/// <summary>
/// Regras de negócio dos planos do StreamingFlix.
/// Todos os métodos retornam dados (string, int, bool) para facilitar os testes unitários.
/// </summary>
public class PlanoStreamingService
{
    /// <summary>
    /// Classifica o plano pela quantidade de telas simultâneas.
    /// 1 tela => "BÁSICO"; 2 telas => "PADRÃO"; 4 ou mais telas => "PREMIUM".
    /// Observação: 3 telas não é citada no enunciado; é tratada como "PADRÃO".
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Quando telasSimultaneas for menor que 1.</exception>
    public string ObterClassificacaoPorQualidade(int telasSimultaneas)
    {
        if (telasSimultaneas < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(telasSimultaneas),
                "A quantidade de telas deve ser de pelo menos 1.");
        }

        if (telasSimultaneas == 1)
        {
            return "BÁSICO";
        }

        if (telasSimultaneas >= 4)
        {
            return "PREMIUM";
        }

        return "PADRÃO";
    }

    /// <summary>
    /// Calcula a mensalidade aplicando desconto pelo tempo de contrato:
    /// menos de 6 meses => sem desconto; 6 a 11 meses => 10%; 12 meses ou mais => 20%.
    /// O cálculo usa aritmética inteira (resultado truncado).
    /// </summary>
    public int CalcularMensalidadeComDesconto(int valorBase, int mesesContratados)
    {
        int percentualDesconto = 0;

        if (mesesContratados >= 12)
        {
            percentualDesconto = 20;
        }
        else if (mesesContratados >= 6)
        {
            percentualDesconto = 10;
        }

        return valorBase * (100 - percentualDesconto) / 100;
    }

    /// <summary>
    /// Retorna true apenas se a idade for maior ou igual a 18 E o controle parental estiver desativado.
    /// </summary>
    public bool PodeAcessarConteudoAdulto(int idade, bool controleParentalAtivo)
    {
        return idade >= 18 && !controleParentalAtivo;
    }
}
