
inicio
    real opcao, salario
    escrever "Menu de op��es: \n"
    escrever "1-Imposto \n"
    escrever "2-Novo sal�rio \n"
    escrever "3-Classifica��o \n"
    escrever "Digite a op��o desejada: "
    ler opcao
    
    escolhe opcao
        caso 1:
        escrever "Digite o sal�rio do funcion�rio: R$ " 
        ler salario
        se salario < 500 ent�o
            escrever "O valor do imposto � de R$ ", (salario *0.05)
        sen�o
            se salario >= 500 e salario <= 850 ent�o
                escrever "O valor do imposto � de R$ ", (salario *0.1)
            sen�o 
                escrever "O valor do imposto � de R$ ", (salario *0.15)
            fimse 
        fimse
        caso 2:
            escrever "Digite o sal�rio do funcion�rio: R$ " 
        ler salario
        se salario < 450 ent�o
            escrever "O valor do aumento � de R$ 100.00."
        sen�o
            se salario >= 450 e salario < 750 ent�o
                escrever "O valor do imposto � de R$ ", (salario *0.1)
            sen�o 
                escrever "O valor do imposto � de R$ ", (salario *0.15)
            fimse 
        fimse
    fimescolhe 
    
fim
