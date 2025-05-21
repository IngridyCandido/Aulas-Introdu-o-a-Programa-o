
inicio
    real n1, n2, n3, media, notaexame

    escrever "Vamos descobrir sua média? "
    
    escrever "Qual a nota da sua 1ª atividade avalitiva (de 0 a 10.0)? "
    ler n1
    
    escrever "Qual a nota da sua 2ª atividade avalitiva (de 0 a 10.0)? "
    ler n2
    
    escrever "Qual a nota da sua 3ª atividade avalitiva (de 0 a 10.0)? "
    ler n3

    media <- (n1 + n2 + n3) / 3.0 

    se media >= 7.0 então 
        escrever "Sua média é " , media , " e você foi aprovado."
    senão
        se media >= 3.0 então
            notaexame <- 12.0 - media 
            escrever "Sua média é " , media , " e você vai precisar fazer um exame e tirar no minimo ", notaexame , "."
        senão
            escrever "Sua média é " , media , " e você está reprovado."
        fimse 
   fimse  
     
fim
