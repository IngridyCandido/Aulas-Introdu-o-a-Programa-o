
inicio
    real n1, n2, n3, media, notaexame

    escrever "Vamos descobrir sua m�dia? "
    
    escrever "Qual a nota da sua 1� atividade avalitiva (de 0 a 10.0)? "
    ler n1
    
    escrever "Qual a nota da sua 2� atividade avalitiva (de 0 a 10.0)? "
    ler n2
    
    escrever "Qual a nota da sua 3� atividade avalitiva (de 0 a 10.0)? "
    ler n3

    media <- (n1 + n2 + n3) / 3.0 

    se media >= 7.0 ent�o 
        escrever "Sua m�dia � " , media , " e voc� foi aprovado."
    sen�o
        se media >= 3.0 ent�o
            notaexame <- 12.0 - media 
            escrever "Sua m�dia � " , media , " e voc� vai precisar fazer um exame e tirar no minimo ", notaexame , "."
        sen�o
            escrever "Sua m�dia � " , media , " e voc� est� reprovado."
        fimse 
   fimse  
     
fim
