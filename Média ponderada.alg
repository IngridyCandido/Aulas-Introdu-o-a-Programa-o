inicio
    real n1, n2, n3, media

    escrever "Vamos descobrir sua m�dia final? "
    
    escrever "Qual a nota do trabalho do laborat�rio? "
    ler n1
    
    escrever "Qual a nota da sua avalia��o semestral? "
    ler n2
    
    escrever "Qual a nota do seu texte final? "
    ler n3

    media <- ((2.0 * n1) + (3.0 * n2) + (n3 *5.0)) / 10 

    se media >= 8 ent�o 
        escrever "Sua m�dia final � " , media , " e seu conceito � A."
    sen�o
        se media >= 7 ent�o
            escrever "Sua m�dia final � " , media , " e seu conceito � B."
        sen�o
            se media >= 6 ent�o
                escrever "Sua m�dia final � " , media , " e seu conceito � C."
            sen�o
                se media >= 5 ent�o 
                    escrever "Sua m�dia final � " , media , " e seu conceito � D."
                sen�o 
                    escrever "Sua m�dia final � " , media , " e seu conceito � E."
                fimse 
            fimse 
        fimse 
   fimse  
    
fim 

