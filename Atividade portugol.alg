
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
          se sexo = "F"  ent�o 
              somafeminino <- somafeminino + 1.0
          sen�o 
              somamasculino <- somamasculino + 1.0
          fimse 
          
          escrever "Qual seu sal�rio? " , "\n"
          ler salario
          somatoriosalarios <- somatoriosalarios + salario //acumulador
          numpessoas <- numpessoas + 1.0 //contador
          se salario > maiorsalario ent�o 
              maiorsalario <- maiorsalario
          fimse 
          se salario < 150.0 ent�o
              numsalarios150 <- numsalarios150 + 1.0
          fimse 
          
          escrever "Qual o n�mero de filhos que voc� possui? ", "\n"
          ler filhos 
          somatoriofilhos <- somatoriofilhos + filhos 

          
      enquanto idade > 0.0
      
      escrever "A media de sal�rios = R$  ", (somatoriosalarios / numpessoas), ".", "\n"
      escrever "A media de numeros de filhos � de ", (somatoriofilhos / numpessoas, ".", "\n"
      escrever "A media da idade das pessoas que responderam a pergunta � de ", (somatorioidade / numpessoas, ".", "\n"
      escrever "O maior sal�rio foi de R$  ", maiorsalario, ".", "\n"
      escrever "A percentagem de pessoas com sal�rios at� R$150 � de ", (numsalarios150 * 100 / numpessoas), "% pessoas.", "\n"
      escrever "A quantidade de mulheres foi de ", somafeminino, " e a quantidade de homens foi de ", somamasculino, ".", "\n"
fim
