using StreamingFlix.App;

var service = new PlanoStreamingService();

Console.WriteLine("=== StreamingFlix ===");
Console.WriteLine($"Plano com 4 telas: {service.ObterClassificacaoPorQualidade(4)}");
Console.WriteLine($"Mensalidade (R$ 50, 12 meses): R$ {service.CalcularMensalidadeComDesconto(50, 12)}");
Console.WriteLine($"Usuário de 20 anos, sem controle parental, acessa conteúdo adulto? {service.PodeAcessarConteudoAdulto(20, false)}");
