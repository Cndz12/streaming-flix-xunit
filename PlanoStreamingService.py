#plano_streaming_service.py

class PlanoStreamingService:
    def obter_classificacao_por_qualidade(self, telas_simultaneas: int) -> str:
        if telas_simultaneas >= 4:
            return "PREMIUM"
        if telas_simultaneas == 2:
            return "PADRÃO"
         return "BÁSICO"

    def calcular_mensalidade_com_desconto(self, valor_base: int, meses_contratados: int): -> float:
        if meses_contratados >= 12:
            return valor_base * 0.8  # 20% de desconto
        if meses_contratados >= 6:
            return valor_base * 0.9  # 10% de desconto
        return float(valor_base)  # Sem desconto

    def pode_acessar_conteudo_adulto(self, idade: int, controle_parental_ativo: bool) -> bool:
        return idade >= 18 and not controle_parental_ativo
    
