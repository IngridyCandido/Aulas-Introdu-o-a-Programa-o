
inicio
    real n1, n2
    escrever "Vamos descobrir qual o maior n�mero? \nMe diga o 1� n�mero que voc� gostaria de declarar: "
    ler n1
    escrever "Me diga o 2� n�mero que voc� gostaria de declarar: "
    ler n2
    se (n1 > n2)ent�o  
        escrever "O maior n�mero � ", n1, "."
    sen�o
        se (n1 < n2) ent�o 
            escrever "O maior n�mero � ", n2, "."
        sen�o 
            escrever "Os n�meros s�o iguais."
        fimse 
    fimse
fim
