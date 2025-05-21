inicio
    real n1, n2, n3, media

    escrever "Vamos descobrir sua média final? "
    
    escrever "Qual a nota do trabalho do laboratório? "
    ler n1
    
    escrever "Qual a nota da sua avaliação semestral? "
    ler n2
    
    escrever "Qual a nota do seu texte final? "
    ler n3

    media <- ((2.0 * n1) + (3.0 * n2) + (n3 *5.0)) / 10 

    se media >= 8 então 
        escrever "Sua média final é " , media , " e seu conceito é A."
    senão
        se media >= 7 então
            escrever "Sua média final é " , media , " e seu conceito é B."
        senão
            se media >= 6 então
                escrever "Sua média final é " , media , " e seu conceito é C."
            senão
                se media >= 5 então 
                    escrever "Sua média final é " , media , " e seu conceito é D."
                senão 
                    escrever "Sua média final é " , media , " e seu conceito é E."
                fimse 
            fimse 
        fimse 
   fimse  
    
fim 

