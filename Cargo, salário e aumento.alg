
inicio
      real salario, aumento, cargo
      escrever "Qual o seu cargo (1-escriturario, 2-secretario, 3-caixa, 4-gerente, 5-diretor)? "
      ler cargo
      escrever "Qual o seu sal�rio atual? R$"
      ler salario
      escolhe cargo 
          caso 1:
              aumento <- salario * 1.5
              escrever "Seu aumento ser� de R$", aumento - salario, " e seu novo salario ser� de R$" , aumento, "."
          caso 2: 
              aumento <- salario * 1.35
              escrever "Seu aumento ser� de R$", aumento - salario, " e seu novo salario ser� de R$" , aumento, "."
          caso 3:
              aumento <- salario * 1.2
              escrever "Seu aumento ser� de R$", aumento - salario, " e seu novo salario ser� de R$" , aumento, "."
          caso 4:
              aumento <- salario * 1.1
              escrever "Seu aumento ser� de R$", aumento - salario, " e seu novo salario ser� de R$" , aumento, "."
          caso 5:
              aumento <- salario * 1
              escrever "Voc� n�o receber� aumento. Seu salario continuar� de R$" , aumento, "."
          defeito: 
              escrever "Esse cargo n�o existe na empresa."
     fimescolhe 
          
fim
