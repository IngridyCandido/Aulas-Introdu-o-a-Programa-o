
inicio
      real numpessoas <- 0
	real idade, salario, filhos, maiorsalario, numsalarios150 
      real somatoriosalarios <- 0.0
      real somafeminino <- 0.0
      real somamasculino <- 0.0
      real somatoriofilhos <- 0.0
      real somatorioidade <- 0.0
      texto sexo
      faz 
          escrever "Qual sua idade? ", "\n"
          ler idade
          somatorioidade <- somatorioidade + idade
          
          escrever "Qual seu sexo? F ou M ", "\n"
          ler sexo 
          se sexo = "F"  então 
              somafeminino <- somafeminino + 1.0
          senão 
              somamasculino <- somamasculino + 1.0
          fimse 
          
          escrever "Qual seu salário? " , "\n"
          ler salario
          somatoriosalarios <- somatoriosalarios + salario //acumulador
          numpessoas <- numpessoas + 1.0 //contador
          se salario > maiorsalario então 
              maiorsalario <- maiorsalario
          fimse 
          se salario < 150.0 então
              numsalarios150 <- numsalarios150 + 1.0
          fimse 
          
          escrever "Qual o número de filhos que você possui? ", "\n"
          ler filhos 
          somatoriofilhos <- somatoriofilhos + filhos 

          
      enquanto idade > 0.0
      
      escrever "A media de salários = R$  ", (somatoriosalarios / numpessoas), ".", "\n"
      escrever "A media de numeros de filhos é de ", (somatoriofilhos / numpessoas, ".", "\n"
      escrever "A media da idade das pessoas que responderam a pergunta é de ", (somatorioidade / numpessoas, ".", "\n"
      escrever "O maior salário foi de R$  ", maiorsalario, ".", "\n"
      escrever "A percentagem de pessoas com salários até R$150 é de ", (numsalarios150 * 100 / numpessoas), "% pessoas.", "\n"
      escrever "A quantidade de mulheres foi de ", somafeminino, " e a quantidade de homens foi de ", somamasculino, ".", "\n"
fim
