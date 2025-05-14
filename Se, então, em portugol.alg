inicio
    inteiro numero,resto
    escrever "Qual o número que você deseja analisar? "
    ler numero
    se numero > 0 então 
        escrever "Seu número é positivo."
    senão
        se numero = 0 então
            escrever "Seu número é Zero."
        senão
            escrever "Seu número é negativo."
        fimse
    fimse
    resto <- número % 2 
    se resto = 0 então
        escrever " E seu número é par."
    senão 
        escrever " E seu número é impar."
    fimse
fim
