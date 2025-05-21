
inicio
      real salario, aumento, cargo
      escrever "Qual o seu cargo (1-escriturario, 2-secretario, 3-caixa, 4-gerente, 5-diretor)? "
      ler cargo
      escrever "Qual o seu salário atual? R$"
      ler salario
      escolhe cargo 
          caso 1:
              aumento <- salario * 1.5
              escrever "Seu aumento será de R$", aumento - salario, " e seu novo salario será de R$" , aumento, "."
          caso 2: 
              aumento <- salario * 1.35
              escrever "Seu aumento será de R$", aumento - salario, " e seu novo salario será de R$" , aumento, "."
          caso 3:
              aumento <- salario * 1.2
              escrever "Seu aumento será de R$", aumento - salario, " e seu novo salario será de R$" , aumento, "."
          caso 4:
              aumento <- salario * 1.1
              escrever "Seu aumento será de R$", aumento - salario, " e seu novo salario será de R$" , aumento, "."
          caso 5:
              aumento <- salario * 1
              escrever "Você não receberá aumento. Seu salario continuará de R$" , aumento, "."
          defeito: 
              escrever "Esse cargo não existe na empresa."
     fimescolhe 
          
fim
