
inicio
    real n1, n2
    escrever "Vamos descobrir qual o maior número? \nMe diga o 1° número que você gostaria de declarar: "
    ler n1
    escrever "Me diga o 2° número que você gostaria de declarar: "
    ler n2
    se (n1 > n2)então  
        escrever "O maior número é ", n1, "."
    senão
        se (n1 < n2) então 
            escrever "O maior número é ", n2, "."
        senão 
            escrever "Os números são iguais."
        fimse 
    fimse
fim
