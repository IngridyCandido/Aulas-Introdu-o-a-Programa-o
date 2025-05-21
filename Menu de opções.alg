
inicio
    real opcao, salario
    escrever "Menu de opções: \n"
    escrever "1-Imposto \n"
    escrever "2-Novo salário \n"
    escrever "3-Classificação \n"
    escrever "Digite a opção desejada: "
    ler opcao
    
    escolhe opcao
        caso 1:
        escrever "Digite o salário do funcionário: R$ " 
        ler salario
        se salario < 500 então
            escrever "O valor do imposto é de R$ ", (salario *0.05)
        senão
            se salario >= 500 e salario <= 850 então
                escrever "O valor do imposto é de R$ ", (salario *0.1)
            senão 
                escrever "O valor do imposto é de R$ ", (salario *0.15)
            fimse 
        fimse
        caso 2:
            escrever "Digite o salário do funcionário: R$ " 
        ler salario
        se salario < 450 então
            escrever "O valor do aumento é de R$ 100.00."
        senão
            se salario >= 450 e salario < 750 então
                escrever "O valor do imposto é de R$ ", (salario *0.1)
            senão 
                escrever "O valor do imposto é de R$ ", (salario *0.15)
            fimse 
        fimse
    fimescolhe 
    
fim
